using UnityEngine;
// Сохранить через сохранялочку)))
public class InstantiateShop : MonoBehaviour
{
    private static bool isLoaded = false;
    private string resourceFilePath = "UI/Shop/Shop";

    public void LoadSettings()
    {
        if (!isLoaded)
        {
            isLoaded = true;
            GameObject prefab = Resources.Load<GameObject>(resourceFilePath);
            GameObject gameObject = Instantiate(prefab);
            Debug.Log("Complete!!!");
        }
    }

    private void Awake()
    {
        LoadSettings();
    }
}
