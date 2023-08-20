using TMPro;
using UnityEngine;
using UnityEngine.UI;
// Выводится UI, на которой находятся Иконка, Название награды, награда, условия выполнения
public abstract class AbstractAchievements : MonoBehaviour
{
    [SerializeField] public Achievements achievement;
    protected Image _image;                                    // UI Image
    protected Image _bar;                                      // Прогресс Бар
    [Range(0, 1)] protected float _progress;                   // Переменная для деления Бара
    protected TextMeshProUGUI _nameOfAchievement;              // Название текст
    protected TextMeshProUGUI _conditionOfAchievement;         // Условие  текст
    protected bool _achievementComplete = false;               // Достижение выполнено

    protected Sprite[] _sprite;                                // Картинки


    protected int[] _checkValue;   

    protected int _size;            // Размер массива

    protected float collectedValue = 0;
    protected int countComplete = 0;

    public enum Achievements
    {
        ALL_COINS,
        ALL_LEVELS,
        ALL_UPGRADES,
        COUNT_USED_SKILLS,
        ACOUNT_DEATHS,
    }
}