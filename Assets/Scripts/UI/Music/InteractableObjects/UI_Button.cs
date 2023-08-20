using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class UI_Button : InteractableGameObject
{
    private static StringBuilder interactObjectFilePath = new StringBuilder("Music/");
    private static string[] audioEffects = new string[] { "Imp_Effect_1", "Pos_Effect_2" };
    //private static string[] animations = new string[] { "Imp_Animation", "Pos_Animation" };

    public void TryInteract()
    {

        PlayAudioEffect(interactObjectFilePath, audioEffects);   // Класс Звука // проиграть звук (Ручки и петель двери через Params)

        //Animation(interactivity, interactObjectFilePath, animations);           // Класс анимации

        if (Interaction.IMPOSSIBLE == interact)
            return;

        //Action();     // Действие вызывается из этого класса  (Для каждого объекта он будет абстрактный, может выполнять какое-то действие либо просто передавать параметр что с ним нечего делать)
    }

}
