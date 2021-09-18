
using UnityEngine;

namespace ObjectTemplate.Extention
{
    // TODO : ���� Ȯ���� �߰��ϱ�
    // ex ) x�ุ ����, y�ุ ���� ���
    public static class VectorExtension
    {
        public static Vector3 GetRandomVector(this Vector3 vector3, float randomRange, bool notMinus = false)
        {
            vector3 = Vector3.one * Random.Range(notMinus ? 0 : -randomRange, randomRange);
            return vector3;
        }

        public static Vector3 GetRandomVector(this Vector3 vector3, Vector3 randomRange, bool notMinus = false)
        {
            vector3 = new Vector3(Random.Range(notMinus ? 0 : -randomRange.x, randomRange.x), Random.Range(notMinus ? 0 : -randomRange.y, randomRange.y), Random.Range(notMinus ? 0 : -randomRange.z, randomRange.z));
            return vector3;
        }

        public static Vector3 GetRandomVector(this Vector3 vector3, bool notMinus = false)
        {
            vector3 = new Vector3(Random.Range(notMinus ? 0 : -vector3.x, vector3.x), Random.Range(notMinus ? 0 : -vector3.y, vector3.y), Random.Range(notMinus ? 0 : -vector3.z, vector3.z));
            return vector3;
        }
    }
}