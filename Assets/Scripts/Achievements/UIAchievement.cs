using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIAchievement : AbstractAchievements
{
    private void Start()
    {
        // При первом запуске программы
        index = (int)achievement;
        _size = AchievementStorage._size[index];
        initializeArray3(index, _size);
        AchievementUI(0);        
    }
   
    private string resourceFilePath = "UI/Achievement"; // Через код

    public void initializeArray3(int index, int size)
    {
        _image = transform.Find("ImAchievement").GetComponentInChildren<Image>();
        _bar = transform.Find("Bar").GetComponentInChildren<Image>();

        _nameOfAchievement = transform.Find("NameOfAchievement").GetComponentInChildren<TextMeshProUGUI>();
        _conditionOfAchievement = transform.Find("ConditionOfAchievement").GetComponentInChildren<TextMeshProUGUI>();


        _checkValue = new int[size];
        for (int i = 0; i < size; i++)
        {
            _checkValue[i] = AchievementStorage.checkValue[index][i];
        }

        _sprite = Resources.LoadAll<Sprite>(resourceFilePath);
    }
    int index;
    public void SelectAchievement()
    {
        //  index = (int)achievement;
        // Выполняется достижение с таким параметром

        AchievementInProgress(ref collectedValue, ref _size, ref _checkValue, ref countComplete/*, achievements*/);
    }




    // addCollectedValue - (кол-во наносимого урона или стоимость монет)
    //public void AchievementInProgress(ref float collectedParameter, ref int size, ref int[] checkCollectedParameter, ref int countComplete,/* Achievements achievements,*/ float addCollectedValue = 1)
    public void AchievementInProgress(ref float collectedParameter, ref int size, ref int[] checkCollectedParameter, ref int countComplete,/* Achievements achievements,*/ float addCollectedValue = 1)
    {


        if (_achievementComplete) return;  // Достижения закончились
        collectedParameter += addCollectedValue;                 // Проверяемый параметр  (Передавать через скобки)

        ConditionOfAchievement();

        for (int i = 1; i < size; i++)
        {
            if (collectedParameter >= checkCollectedParameter[countComplete + 1])
            {
                if (countComplete < size - 2)
                {
                    countComplete++;
                    break;
                }
            }
        }
        _progress = (collectedParameter - checkCollectedParameter[countComplete]) / (checkCollectedParameter[countComplete + 1] - checkCollectedParameter[countComplete]);
        if (_progress > 1) _progress = 1;

        _bar.fillAmount = _progress;


        //return collectedValue[index];
    }

    public void ConditionOfAchievement()   // Сбор данных и проверка условия для достижения
    {
        for (int i = countComplete + 1; i < _size; i++)
        {
            if (collectedValue >= _checkValue[i])
            {
                AchievementUI(i);
                if (collectedValue >= _checkValue[_size - 1])
                    _achievementComplete = true;
            }
        }
    }

    public void AchievementUI(int i)                                              // Изменение (Бара, текста)
    {
        _nameOfAchievement.text = AchievementStorage._completeNameOfAchievementClass[index][i];//_completeNameOfAchievement[i];
        _conditionOfAchievement.text = AchievementStorage._completeConditionOfAchievementClass[index][i];
        _image.sprite = _sprite[i];

    }

    public void SaveTargetValue() // Сохранение прогресса  
    {

    }

}