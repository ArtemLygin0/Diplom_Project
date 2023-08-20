using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// ������������
// ������ ������������� ����� ��������� ���� (���� (������, ����, ����������, ���������) �������, ������    //---

// ��������� ������ � �������� (��������� Mute + �������� ������)                                           //+++
// ��� �������� �� ����� ������ �� �����������                                                              //+++   (���� ������ ������ ������� ����������, ���������)
// ���� ������ �� 1 �����                                                                                   //---
// ������� �����������                                                                                      //+++
// �� ����� �������� ����� ����� ��������                                                                   //+++

// ����� ����������
// ��� ������� ������� ���� ��������� (������ ����� �������� �����)                                         //---

// �� ������������
// (����� ������� �� �������� ����� ���� ����� (������� "���������"))
// ������ ����� � ��������� ������  // (�������� ��������� ����� � ����������� ���������)

// ������� ������ ������

// ��������� ����� � ����� �������� ������ ���� �� ����� UI

// 0 ������� ��� ������
// 1 ������� �� ������� ������
// 2 ������� ��������

// ��������� ����� �� �������� ������ ������� ����
// ��� �������� �� ����� (��� �������) ����� ����� ������ ��� �����������
// ����� ������� ����� ����� �������� ���� � ������ ���� ��� ������� ������
// ������� �����, enum + ����� ������� ����� ��������� ����� ������.
// ��������� ��������� �� ����� ������ � �������� � ����������� �����������


// ������ ��������� ������, ��������� ������ ���������      // ��� ������ �� ����� � ����� ����� �������� �� ������ //+++++ (17)
// ������� ��� ����� sourceMusic � sourceEffects �� �����������, ����� � �������� ��������� ��� ��������� �����     //+++++ (17)
// ����� �������� � ������ � ������� ������ ���������� ������ ��� �������������� � ���������                        //+++++ (17)
// ��� ������� �� ������ ����� ����� ����� ���� ������� (�������� �����������) � ������ � �������

public class AuidioSettings : MonoBehaviour
{
    private Button toggleMusic;      // ����� �������� �������� �� ������
    private Button toggleEffect;

    private Sprite audioOn;    // ������ ��������
    private Sprite audioOff;   // ������ ���������

    private Slider volumeMusicSlider;     // ��������� ���������
    private Slider volumeEffectsSlider;     // ��������� ���������

    public static AudioSource sourceMusic;
    public static AudioSource sourceEffects;

    private string resourceFilePath1 = "Images/ImAchievement0";
    private string resourceFilePath2 = "Images/ImAchievement1";

    //private GameObject closeSettings;
    private void Start()
    {
        sourceMusic = GameObject.Find("SourceMusic").GetComponent<AudioSource>();
        sourceEffects = GameObject.Find("SourceEffects").GetComponent<AudioSource>();

        toggleMusic = transform.Find("MusicBtn").GetComponentInChildren<Button>();
        toggleEffect = transform.Find("EffectsBtn").GetComponentInChildren<Button>();

        audioOn = Resources.Load<Sprite>(resourceFilePath1);
        audioOff = Resources.Load<Sprite>(resourceFilePath2);

        volumeMusicSlider = transform.Find("MusicSlider").GetComponentInChildren<Slider>();
        volumeEffectsSlider = transform.Find("EffectsSlider").GetComponentInChildren<Slider>();

        //closeSettings = GameObject.Find("AudioSettings");
    }

    private void Update()
    {
        sourceMusic.volume = volumeMusicSlider.value;
        sourceEffects.volume = volumeEffectsSlider.value;

        //CloseSettings();
    }

    // ���������/���������� ����� (��������� �������)  || ������� ����� ������� �������� ��� � ����������
    public void ToggleMusic()
    {
        sourceMusic.mute = !sourceMusic.mute;
        if (sourceMusic.mute)
            toggleMusic.image.sprite = audioOff;
        else
            toggleMusic.image.sprite = audioOn;
    }

    public void ToggleEffects()
    {
        sourceEffects.mute = !sourceEffects.mute;
        if (sourceEffects.mute)
            toggleEffect.image.sprite = audioOff;
        else
            toggleEffect.image.sprite = audioOn;
    }
    /*
    public void CloseSettings()
    {
        if (Input.GetKeyDown(KeyCode.G))
            closeSettings.gameObject.SetActive(!closeSettings.activeSelf);
    }
    */
    /*
    public void ToggleConversation()    // ������� 
    {

    }

    public void ToggleSubtitles()       // ��������
    {

    }
    */

    /*
    private void SaveSettins()
    {
        PlayerPrefs.SetFloat(this.saveVolumeKey, this.volume);
    }
    */
}