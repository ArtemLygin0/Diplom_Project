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

        PlayAudioEffect(interactObjectFilePath, audioEffects);   // ����� ����� // ��������� ���� (����� � ������ ����� ����� Params)

        //Animation(interactivity, interactObjectFilePath, animations);           // ����� ��������

        if (Interaction.IMPOSSIBLE == interact)
            return;

        //Action();     // �������� ���������� �� ����� ������  (��� ������� ������� �� ����� �����������, ����� ��������� �����-�� �������� ���� ������ ���������� �������� ��� � ��� ������ ������)
    }

}
