using UnityEngine;

public class InstantiateAudioSettings : MonoBehaviour
{
    private static bool isLoaded = false;
    private string resourceFilePath = "UI/AudioSettings/AudioSettingsCanvas";

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
