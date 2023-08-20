using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransfer : MonoBehaviour
{
    // При запуске игры один раз создаёт Instantiate, префаб Настроек и делает метод получения значений, при выходе должен сохранять настройки
    public GameObject[] objectsToSave;
    private string sceneName4 = "MusicRoom";

    public void MusicRoom()
    {
        // Не удалять музыку
        RelocateObjects();
        SceneManager.LoadSceneAsync(sceneName4);
    }
    
    private string sceneName_1 = "Level_1";
    
    public void Level_1()
    {
        // Не удалять музыку
        RelocateObjects();
        SceneManager.LoadSceneAsync(sceneName_1);
    }
    
    public void LoadLevel(string nextLevel)
    {
        RelocateObjects();
        SceneManager.LoadSceneAsync(nextLevel);
    }

    // Рабочий метод
    public void RelocateObjects()
    {
        for (int i = 0; i < objectsToSave.Length; i++)
        {
            DontDestroyOnLoad(objectsToSave[i]);
        }
    }
}
