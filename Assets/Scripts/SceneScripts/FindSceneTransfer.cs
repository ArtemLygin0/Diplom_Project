using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindSceneTransfer : MonoBehaviour
{
    [SerializeField] private string nextLevel;
    private SceneTransfer sceneTransfer;

    private void Awake()
    {
        sceneTransfer = GameObject.Find("Saves").GetComponent<SceneTransfer>();
    }

    public void NextLevel()
    {
        sceneTransfer.LoadLevel(nextLevel);
    }
}
