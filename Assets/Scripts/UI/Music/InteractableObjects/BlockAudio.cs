using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class BlockAudio : InteractableGameObject    // + 3D
{
    private static StringBuilder interactObjectFilePath = new StringBuilder("Music/");
    private static string[] audioEffects = new string[] { "Imp_Effect_1", "Pos_Effect_2" };
    [HideInInspector] public bool loop = true;

    public void TryInteract()
    {
        PlayAudioEffect(interactObjectFilePath, audioEffects, 1, loop);
        //PlayAudioEffect(interactObjectFilePath, audioEffects, loop: loop);   
    }

    public void StopAudioEffect()
    {
        if (!loop)
        {
            CancelInvoke("PlayAudioWithDelay");
        }
    }

}
