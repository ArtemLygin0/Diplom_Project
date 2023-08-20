using UnityEditor;
[CustomEditor(typeof(MyComponent))]
public class MyComponentEditor : Editor
{
    public override void OnInspectorGUI()
    {
        MyComponent myTarget = (MyComponent)target;

        myTarget.DropDown = (MyComponent.myEnum)EditorGUILayout.EnumPopup("Select an item:", myTarget.DropDown);
        if (myTarget.DropDown == MyComponent.myEnum.Item1)
        {
            myTarget.index1 = EditorGUILayout.Popup(myTarget.index1, myTarget.options1);
            if (myTarget.DropDown == MyComponent.myEnum.Item1 || myTarget.DropDown == MyComponent.myEnum.Item2 || myTarget.DropDown == MyComponent.myEnum.Item3)
            {
                myTarget.index2 = EditorGUILayout.Popup(myTarget.index2, myTarget.options2);
                if (myTarget.index2 == 0)
                {
                    // здесь вы можете добавить новый всплывающий элемент
                }
            }
        }

        if (myTarget.DropDown == MyComponent.myEnum.Item2)
        {
            myTarget.index1 = EditorGUILayout.Popup(myTarget.index1, myTarget.options1);
            if (myTarget.DropDown == MyComponent.myEnum.Item1 || myTarget.DropDown == MyComponent.myEnum.Item2 || myTarget.DropDown == MyComponent.myEnum.Item3)
            {
                myTarget.index2 = EditorGUILayout.Popup(myTarget.index2, myTarget.options2);
                if (myTarget.index2 == 0)
                {
                    // здесь вы можете добавить новый всплывающий элемент
                }
            }
        }

        if (myTarget.DropDown == MyComponent.myEnum.Item3)
        {
            myTarget.index1 = EditorGUILayout.Popup(myTarget.index1, myTarget.options1);
            if (myTarget.DropDown == MyComponent.myEnum.Item1 || myTarget.DropDown == MyComponent.myEnum.Item2 || myTarget.DropDown == MyComponent.myEnum.Item3)
            {
                myTarget.index2 = EditorGUILayout.Popup(myTarget.index2, myTarget.options2);
                if (myTarget.index2 == 0)
                {
                    // здесь вы можете добавить новый всплывающий элемент
                }
            }
        }
    }
}
