using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class LevelUI : MonoBehaviour
{
    [SerializeField] public int currentLevel;                     // ������� �������
    [SerializeField] private TextMeshProUGUI _timeRecordText;     // ������ �������
    [SerializeField] private TextMeshProUGUI _timeCompleteText;   // ����� ����������
    [SerializeField] private TextMeshProUGUI _resultText;         // ����� �� ����� ����
    [SerializeField] public TextMeshProUGUI _coinText;            // ���-�� ��������� ������� �� ������

    [SerializeField] private Image[] _icon;                       // ������ ������
    public int coins;                                             // ���-�� ��������� ������� �� ������

    [SerializeField] private GameObject lvlUI;                    // ������� �������
    [SerializeField] private GameObject PauseUI;                  // ��������� ������

    private float _timeRecord = float.MaxValue;                   // ��������� �����
    private float _timeComplete = 0;                              // ������� ������� ��

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
            if (GameInfo.savedCoins[currentLevel, i] == true)             // ���� ������ �������, �� ������� � �� �����
            {
                _icon[i].color = Color.green;                                       // ��������� ���� ��� ������ ���� �������
            }   
        // ��������� ����� ���� ��� ����� ������
        if (_timeRecord > _timeComplete)
        {
            _timeRecord = _timeComplete;
            GameInfo.savedTimeRecord[currentLevel] = _timeRecord;
            // ����� ����������
        }

        endLVL = true;
        //Time.timeScale = 0;     // ������������� �����, ���� �� ����� �������� ����� ������
        SetTableValues();
        lvlUI.SetActive(true);
    }

    public void SetTableValues()
    {
        _timeRecordText.text = "Best Time : " + Math.Round(_timeRecord, 2);
        _timeCompleteText.text = "Time : " + Math.Round(_timeComplete, 2);
        _coinText.text = "Coins : " + coins; 
        // �������� �������� � PlayerPrefs
    }
}
