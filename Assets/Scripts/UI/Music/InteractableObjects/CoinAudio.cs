using System.Text;
using UnityEngine;

public class CoinAudio : InteractableGameObject
{
    private static StringBuilder interactObjectFilePath = new StringBuilder("Music/");
    private static string[] audioEffects = new string[] { "Imp_Effect_1", "Pos_Effect_2" };
    [HideInInspector] public bool loop = true;  // Т.к. монетка сразу уничтожается, то цикл не создаётся

    public void TryInteract()
    {
        PlayAudioEffect(interactObjectFilePath, audioEffects);    
    }

    public void StopAudioEffect()
    {
        if (!loop)
        {
            CancelInvoke("PlayAudioWithDelay");
        }
    }
    
}
