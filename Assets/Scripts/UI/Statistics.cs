using System;
using TMPro;
using UnityEngine;

// Кол-во пройдённых уровней 5/100
// Кол-во смертей 31
// Кол-во собранных монет
// Кол-во улучшений 3/15
// Кол-во использованных способностей 63/500

// Обновляется при каждом вызове функций (Достижений)
    


public class Statistics : MonoBehaviour
{
    private TextMeshProUGUI[] statValues;

    private void Start()
    {
        SetStatistic();
    }
    /*
    private int countOfCoins = 0;        // Подобрал монету              //ALL_COINS            ||0
    private int countOfCompleteLvl = 0;  // После прохождения уровня     //ALL_LEVELS           ||1
    private int countOfUpgrades = 0;     // Улучшил навык                //ALL_UPGRADES         ||2
    private int countUsedSkills = 0;     // Использовал навык            //COUNT_USED_SKILLS    ||3
    private int countOfDeaths = 0;       // Метод Die                    //ACOUNT_DEATHS        ||4
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