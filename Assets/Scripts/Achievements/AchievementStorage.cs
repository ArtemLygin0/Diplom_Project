using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Чтобы добавить/изменить новое достижение надо добавить ко всем по 1 элементу
// Чтобы изменить кол-во достижений в ачивке нужно поменять 5 полей (Картинка, название, условие, int условие, размер)

// Сохранение Данных
public class AchievementStorage
{
    public static string[][] _completeNameOfAchievementClass =
        {
        new string[] { "Collector!", "I really love money!", "Money King!", "Achievement completed!" },                     // ALL_COINS            ||+++ 
        new string[] { "Well, let's start!", "What's next?", "Movement Master!", "Achievement completed!" },                // ALL_LEVELS           ||+++
        new string[] { "I know what I need!", "Higher and higher!", "Everything Improved!", "Achievement completed!" },     // ALL_UPGRADES         ||+++ 
        new string[] { "What is this?", "Useful Skill!", "Running on the clouds!", "Achievement completed!" },              // COUNT_USED_SKILLS    ||+++
        new string[] { "It was painful!", "That's all right!", "I won't Give Up!", "Achievement completed!" }               // ACOUNT_DEATHS        ||+++
        };                                                                                                                          
                                                                                                                                    
    public static string[][] _completeConditionOfAchievementClass =                                                                 
        {                                                                                                                           
        new string[] { "Collect 25 coins", "Collect 150 coins", "Collect 300 coins", "" },                  // ALL_COINS        
        new string[] { "Complete 5 levels", "Complete 25 levels", "Complete 50 levels", "" },               // ALL_LEVELS       
        new string[] { "Upgrade skill 5 times", "Upgrade skill 10 times", "Upgrade skill 15 times", "" },   // ALL_UPGRADES     
        new string[] { "Use skill 50 times", "Use skill 250 times", "Use skill 1000 times", "" },           // COUNT_USED_SKILLS
        new string[] { "Lose 50 times", "Lose 250 times", "Lose 1000 times", "" },                          // ACOUNT_DEATHS    
        };

    public static int[][] checkValue =
        {
        new int[] { 0, 25, 150, 300 },      // ALL_COINS
        new int[] { 0, 5, 25, 50 },         // ALL_LEVELS
        new int[] { 0, 5, 10, 15 },         // ALL_UPGRADES
        new int[] { 0, 50, 250, 1000 },     // COUNT_USED_SKILLS
        new int[] { 0, 50, 500, 1000 },     // ACOUNT_DEATHS
        };

    public static int[] _size = { 4, 4, 4, 4, 4 };

    public static int[] collectedValue = new int[] { 0, 0, 0, 0, 0 };

    public static int[] countComplete = new int[] { 0, 0, 0, 0, 0 };

}
