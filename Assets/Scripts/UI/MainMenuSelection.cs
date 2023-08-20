using UnityEngine;

public class MainMenuSelection : MonoBehaviour
{
    [SerializeField] private GameObject firstCanvas;
    [SerializeField] private GameObject secondCanvas;

    public void Button_Open_Close()
    {
        firstCanvas.SetActive(!firstCanvas.activeSelf);
        secondCanvas.SetActive(!secondCanvas.activeSelf);
    }
}