using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class LevelUI : MonoBehaviour
{
    [SerializeField] public int currentLevel;                     // Текущий уровень
    [SerializeField] private TextMeshProUGUI _timeRecordText;     // Рекорд времени
    [SerializeField] private TextMeshProUGUI _timeCompleteText;   // Время прохожения
    [SerializeField] private TextMeshProUGUI _resultText;         // Время во время игры
    [SerializeField] public TextMeshProUGUI _coinText;            // Кол-во собранных монеток на уровне

    [SerializeField] private Image[] _icon;                       // Номера иконок
    public int coins;                                             // Кол-во собранных монеток на уровне

    [SerializeField] private GameObject lvlUI;                    // Уровень пройден
    [SerializeField] private GameObject PauseUI;                  // Остановка уровня

    private float _timeRecord = float.MaxValue;                   // Рекордное время
    private float _timeComplete = 0;                              // Уровень пройден за

    public static bool timerlock = false;
    private bool endLVL = false;

    private void Start()
    {
        Time.timeScale = 1;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && (!endLVL))
        {
            PauseUI.SetActive(!PauseUI.activeSelf);

            timerlock = !timerlock;

            if (timerlock)
            {
                Cursor.lockState = CursorLockMode.Confined;
                Time.timeScale = 0;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
                Time.timeScale = 1;
            }
        }
    }
    void FixedUpdate()
    {
        if (!timerlock)
        {
            _timeComplete += Time.deltaTime;
            _resultText.text = "Time : " + Math.Round(_timeComplete, 2);
        }
    }

    public void LevelComplete()
    {
        for (int i = 0; i < _icon.Length; i++)
            if (GameInfo.savedCoins[currentLevel, i] == true)             // Если монета собрана, то вывести её на экран
            {
                _icon[i].color = Color.green;                                       // Установка того что монета была собрана
            }   
        // Сохраняет время если оно новый рекорд
        if (_timeRecord > _timeComplete)
        {
            _timeRecord = _timeComplete;
            GameInfo.savedTimeRecord[currentLevel] = _timeRecord;
            // Метод сохранения
        }

        endLVL = true;
        //Time.timeScale = 0;     // Останавливает время, если не нужны действия после победы
        SetTableValues();
        lvlUI.SetActive(true);
    }

    public void SetTableValues()
    {
        _timeRecordText.text = "Best Time : " + Math.Round(_timeRecord, 2);
        _timeCompleteText.text = "Time : " + Math.Round(_timeComplete, 2);
        _coinText.text = "Coins : " + coins; 
        // Записать значения в PlayerPrefs
    }
}
