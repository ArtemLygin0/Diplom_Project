using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

// PlayMusic используется при запуске сцены и переходе между локациями

public class MusicSelection : MonoBehaviour
{
    [SerializeField] private Music musicList;
    private AudioClip music;

    private static StringBuilder interactObjectFilePath = new StringBuilder("Music/");
    private static string[] musicArray = new string[] { "Imp_Effect_1", "Pos_Effect_2" };
    protected StringBuilder filePath;
    private int lastIndex = -1;
    /*
    private void Start()
    {
        PlayMusic();
    }
    */
    public void PlayMusic()     // Запускается при загрузке сцены 
    {
        int indexEffect = (int)musicList;

        if (lastIndex != indexEffect)
        {
            filePath = new StringBuilder(interactObjectFilePath.ToString());
            filePath.Append(musicArray[indexEffect]);

            music = Resources.Load<AudioClip>(filePath.ToString());
            lastIndex = indexEffect;
        }

        AuidioSettings.sourceMusic.loop = true;
        AuidioSettings.sourceMusic.clip = music;

        if (AuidioSettings.sourceMusic.isPlaying)
            AuidioSettings.sourceMusic.Pause();
        else
            AuidioSettings.sourceMusic.Play();
    }

    public enum Music
    {
        Level_1_10,
        Level_1_20,
        Level_1_30,
        Level_1_40,
        Level_1_50,
    }
}