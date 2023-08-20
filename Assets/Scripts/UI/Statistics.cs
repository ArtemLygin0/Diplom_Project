using System;
using TMPro;
using UnityEngine;

// ���-�� ��������� ������� 5/100
// ���-�� ������� 31
// ���-�� ��������� �����
// ���-�� ��������� 3/15
// ���-�� �������������� ������������ 63/500

// ����������� ��� ������ ������ ������� (����������)
    


public class Statistics : MonoBehaviour
{
    private TextMeshProUGUI[] statValues;

    private void Start()
    {
        SetStatistic();
    }
    /*
    private int countOfCoins = 0;        // �������� ������              //ALL_COINS            ||0
    private int countOfCompleteLvl = 0;  // ����� ����������� ������     //ALL_LEVELS           ||1
    private int countOfUpgrades = 0;     // ������� �����                //ALL_UPGRADES         ||2
    private int countUsedSkills = 0;     // ����������� �����            //COUNT_USED_SKILLS    ||3
    private int countOfDeaths = 0;       // ����� Die                    //ACOUNT_DEATHS        ||4
    */
    public static string[] _statValuesClass = new string[] { "CountOfCoins : ", "CountOfCompleteLvl  : ", "CountOfUpgrades  : ", "CountUsedSkills : ", "CountOfDeaths : " };
    private void Awake()
    {
        statValues = GetComponentsInChildren<TextMeshProUGUI>();
        SetStatistic();
    }

    /*
    public void GetStatistic()
    {
        countOfCoins = AchievementStorage.collectedValue[0];
        countOfCompleteLvl = AchievementStorage.collectedValue[1];
        countOfUpgrades = AchievementStorage.collectedValue[2];
        countUsedSkills = AchievementStorage.collectedValue[3];
        countOfDeaths = AchievementStorage.collectedValue[4];
    }
    */
    public void SetStatistic()
    {
        for (int i = 0; i < statValues.Length; i++)
        {
            statValues[i].text = $"{ _statValuesClass[i]} {AchievementStorage.collectedValue[i]}";
        }
    }



}