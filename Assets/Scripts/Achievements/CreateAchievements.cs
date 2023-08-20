using UnityEngine;

// Создание достижений на сцене, обращение к полям

public class CreateAchievements : MonoBehaviour
{
    //private UIAchievement UIAchievement;
    [SerializeField] private UIAchievement _UIAchievement = new UIAchievement();

    private void Awake()
    {
        UIAchievement _UIAchievement = new UIAchievement();

    }
}
