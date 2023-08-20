using System.Text;
using UnityEngine;

public class LaserAudio : InteractableGameObject
{
    private static StringBuilder interactObjectFilePath = new StringBuilder("Music/");
    private static string[] audioEffects = new string[] { "Laser", "Laser" };
    [HideInInspector] public bool loop = true;

    public void TryInteract()
    {
        PlayAudioEffect(interactObjectFilePath, audioEffects, 0.5f, loop);    
    }

    public void StopAudioEffect()
    {
        if (!loop)
        {
            CancelInvoke("PlayAudioWithDelay");
        }
    }
    
}
