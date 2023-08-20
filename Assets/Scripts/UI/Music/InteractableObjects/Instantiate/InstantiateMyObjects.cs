using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateMyObjects : MonoBehaviour
{
    [SerializeField] private MyObjects myObjects;
    private bool isLoaded = false;
    private string[] resourceFilePath = { "UI/Shop/Shop", "UI/AudioSettings/AudioSettingsCanvas" };
    

    public void LoadSettings()
    {
        if (!isLoaded)
        {
            isLoaded = true;
            GameObject prefab = Resources.Load<GameObject>(resourceFilePath[(int)myObjects]);
            GameObject gameObject = Instantiate(prefab);
            Debug.Log("Complete!!!");
        }
    }

    private void Awake()
    {
        LoadSettings();
    }


    enum MyObjects
    {
        SHOP,
        AUDIO_SETTINGS,
    }
}
