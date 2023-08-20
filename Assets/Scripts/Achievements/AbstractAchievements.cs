using TMPro;
using UnityEngine;
using UnityEngine.UI;
// ��������� UI, �� ������� ��������� ������, �������� �������, �������, ������� ����������
public abstract class AbstractAchievements : MonoBehaviour
{
    [SerializeField] public Achievements achievement;
    protected Image _image;                                    // UI Image
    protected Image _bar;                                      // �������� ���
    [Range(0, 1)] protected float _progress;                   // ���������� ��� ������� ����
    protected TextMeshProUGUI _nameOfAchievement;              // �������� �����
    protected TextMeshProUGUI _conditionOfAchievement;         // �������  �����
    protected bool _achievementComplete = false;               // ���������� ���������

    protected Sprite[] _sprite;                                // ��������


    protected int[] _checkValue;   

    protected int _size;            // ������ �������

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