# ConditionallyVisibleAttribute
[��ó](https://github.com/cocodding0723/UnityToolbag/tree/main/ConditionallyVisiblePropertyDrawer)

�� [PropertyDrawer](https://docs.unity3d.com/ScriptReference/PropertyDrawer.html) �� ������Ƽ�� `true`���� ������ �ش� ������Ƽ�� ����� ������Դϴ�.   

Example
```cs
class MyBehavior : MonoBehavior
{
    public bool showSomeValue;

    [ConditionallyVisible(nameof(showSomeValue))]
    public float someValue;
}
```  

�ν�����â�� `showSomeValue` üũ�ڽ��� ǥ���ϰ� ����ڰ� üũ�ڽ��� ������ ��쿡�� ������Ƽ ���� ǥ���մϴ�. 
 
�� ����� ����Ʈ�� ������̰ų� ���� ��ȯ�� ���� ����Ǵ� �ʵ尡 �ִ� ��� �����մϴ�.

![./example.gif](https://github.com/cocodding0723/UnityToolbag/raw/main/ConditionallyVisiblePropertyDrawer/example.gif)