using UnityEngine;

public class MyComponent : MonoBehaviour
{
    public enum myEnum { Item1, Item2, Item3 };
    public myEnum DropDown = myEnum.Item1; // будет отображаться как выпадающий список

    public string[] options1 = new string[] { "Option1", "Option2", "Option3" };
    public int index1 = 0;

    public string[] options2 = new string[] { "Option4", "Option5", "Option6" };
    public int index2 = 0;

    public string[] options3 = new string[] { "Option7", "Option8", "Option9" };
    public int index3 = 0;
}