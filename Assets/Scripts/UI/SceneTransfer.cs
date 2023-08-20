using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransfer : MonoBehaviour
{
    // ��� ������� ���� ���� ��� ������ Instantiate, ������ �������� � ������ ����� ��������� ��������, ��� ������ ������ ��������� ���������
    public GameObject[] objectsToSave;
    private string sceneName4 = "MusicRoom";

    public void MusicRoom()
    {
        // �� ������� ������
        RelocateObjects();
        SceneManager.LoadSceneAsync(sceneName4);
    }
    
    private string sceneName_1 = "Level_1";
    
    public void Level_1()
    {
        // �� ������� ������
        RelocateObjects();
        SceneManager.LoadSceneAsync(sceneName_1);
    }
    
    public void LoadLevel(string nextLevel)
    {
        RelocateObjects();
        SceneManager.LoadSceneAsync(nextLevel);
    }

    // ������� �����
    public void RelocateObjects()
    {
        for (int i = 0; i < objectsToSave.Length; i++)
        {
            DontDestroyOnLoad(objectsToSave[i]);
        }
    }
}
