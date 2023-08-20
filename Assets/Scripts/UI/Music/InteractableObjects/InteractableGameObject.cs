using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class InteractableGameObject : MonoBehaviour
{
    [SerializeField] protected Interaction interact;
    [SerializeField] protected AudioSource audioSource;
    protected AudioClip audioEffect;
    protected int indexEffect = 0;
    protected StringBuilder filePath;

    private int lastIndex = -1;

    public void PlayAudioEffect(StringBuilder interactObjectFilePath, string[] audioEffects, float repeatTime = 1, bool loop = false, int countRepeats = 1)
    {
        indexEffect = (int)interact;

        if (lastIndex != indexEffect)
        {
            filePath = new StringBuilder(interactObjectFilePath.ToString());
            filePath.Append(audioEffects[indexEffect]);

            audioEffect = Resources.Load<AudioClip>(filePath.ToString());
            lastIndex = indexEffect;
        }
        InvokeRepeating("PlayAudioWithDelay", 0, repeatTime);
        if (!loop)
        {
            Invoke("StopAudioWithDelay", repeatTime * countRepeats);
        }
    }

    public void StopAudioWithDelay()
    {
        CancelInvoke("PlayAudioWithDelay");
    }
  
    public void PlayAudioWithDelay()    
    {
        if (audioSource != null)
            audioSource.PlayOneShot(audioEffect, AuidioSettings.sourceEffects.volume);  // 3D   (Триггер который делает шаги за стенкой) (Указать место воспроизведения)
        else
            AuidioSettings.sourceEffects.PlayOneShot(audioEffect, AuidioSettings.sourceEffects.volume); // 2D
    }

    public enum Interaction : byte
    {
        IMPOSSIBLE,
        POSSIBLY
    }
}
