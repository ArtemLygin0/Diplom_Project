using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseWindow : MonoBehaviour
{
    [SerializeField] private GameObject closeTable;
    public void Close_Window()
    { 
        closeTable.SetActive(false);
    }
}
