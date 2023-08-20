using UnityEngine;

public class CloseTable : MonoBehaviour
{
    [SerializeField] private GameObject closeTable;
    [SerializeField] private Key key;
    //[SerializeField] private GameObject eventObject;
    enum Key    // Не реагирует на ошибку в названии клавиши (т.к. стоит TryParse)
    {
        Alpha1,
        Alpha2,
        Alpha3,
        Alpha4,
    }

    void Update()
    {
        Open_Close();
    }

    public void Open_Close()
    {
        if (System.Enum.TryParse(key.ToString(), out KeyCode keyCode) && Input.GetKeyDown(keyCode))
        {
            if (closeTable != null)
            {
                closeTable.SetActive(!closeTable.activeSelf);
                //eventObject.SetActive(!eventObject.activeSelf);
                if (closeTable.activeSelf)
                {
                    Cursor.lockState = CursorLockMode.Confined;
                    
                    //Time.timeScale = 0;
                }
                else
                {
                    Cursor.lockState = CursorLockMode.Locked;
                    //Time.timeScale = 1;
                }
            }
        }
    }

    public void Button_Open_Close()
    {
        if (closeTable != null)
        {
            closeTable.SetActive(!closeTable.activeSelf);
            //eventObject.SetActive(!eventObject.activeSelf);
            if (closeTable.activeSelf)
            {
                Cursor.lockState = CursorLockMode.Confined;

                //Time.timeScale = 0;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
                //Time.timeScale = 1;
            }
        }
     
    }
}