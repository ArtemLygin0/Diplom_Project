using UnityEngine;

// �������� ���������� �� �����, ��������� � �����

public class CreateAchievements : MonoBehaviour
{
    //private UIAchievement UIAchievement;
    [SerializeField] private UIAchievement _UIAchievement = new UIAchievement();

    private void Awake()
    {
        UIAchievement _UIAchievement = new UIAchievement();

    }
}
