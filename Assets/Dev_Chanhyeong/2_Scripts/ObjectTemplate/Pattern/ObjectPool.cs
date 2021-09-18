using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

namespace ObjectTemplate{
    [System.Serializable]
    public class ObjectPool<T> where T : MonoBehaviour {
        // FIXME : ��ü ������ ��ħ, ���� ���� ����
        public List<T> Objects => objects;
        [SerializeField]
        private int cashCount;
        [SerializeField]
        private Transform parent;
        [SerializeField]
        private GameObject prefab;
        // FIXME : Ŭ������ �ǹ̸� ��ħ, ���� ���� ����
        public T Data => objects[0];
        // FIXME : Ŭ������ �ǹ̸� ��ħ, ���� ���� ����
        public T Current => objects[listIndex];
        protected List<T> objects = new List<T>();
        protected int listIndex = 0;

        /// <summary>
        /// ������Ʈ Ǯ ������
        /// </summary>
        /// <param name="_cashCount">ĳ���� ����</param>
        /// <param name="_parent">�θ� Transform</param>
        /// <param name="_prefab">Instantiate �� ������Ʈ</param>
        public ObjectPool(int _cashCount, Transform _parent, GameObject _prefab){
            cashCount = _cashCount;
            parent = _parent;
            prefab = _prefab;
        }

        public void Create(){
            for (int i = 0 ; i < cashCount; i++)
            {
                GameObject obj = GameObject.Instantiate(prefab, parent);
                objects.Add(obj.GetComponent<T>());
                obj.SetActive(false);
            }
        }
        
        // FIXME : Dispatcher ��ũ��Ʈ�� ����� Create��� �ٶ�, ���� ���� ����
        public IEnumerator DelayCreate(float delayTime){
            for (int i = 0 ; i < cashCount; i++)
            {
                GameObject obj = GameObject.Instantiate(prefab, parent);
                objects.Add(obj.GetComponent<T>());
                obj.SetActive(false);

                yield return new WaitForSeconds(delayTime);
            }

            yield return null;
        }

        public void AllDisable()
        {
            for (int i = 0; i < cashCount; i++)
            {
                objects[i].gameObject.SetActive(false);
            }
        }
        
        /// <summary>
        /// �ش� ������Ʈ Ǯ�� ����Ʈ�� ���� �ʱ�ȭ��Ŵ
        /// </summary>
        public void Clear(){
            objects.Clear();
            objects = null;
        }

        public T Pop(bool instantActive = false){
            if (listIndex == cashCount) listIndex = 0;
            return objects[listIndex++];
        }
    }
}