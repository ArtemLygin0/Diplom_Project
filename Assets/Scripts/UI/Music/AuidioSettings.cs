using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Обязательные
// Музыка проигрывается везде одинаково темы (Меню (уровни, меню, статистика, Настройки) Магазин, Уровни    //---

// Настройки музыки и эффектов (Выключить Mute + изменить иконку)                                           //+++
// При переходе на сцену музыка не дублируется                                                              //+++   (Меню музыки всегда остаётся включенным, отключить)
// Одна музыка на 1 сцену                                                                                   //---
// Эффекты музыкальные                                                                                      //+++
// На каких объектах какие звуки выпадают                                                                   //+++

// После скриптинга
// Для сложных уровней своя особенная (музыка босса пройдена глава)                                         //---

// Не обязательные
// (Может перейти на следущую песню если хочет (клавиши "Подсказка"))
// Убрать песни с Авторским правом  // (Пометить авторское право и возможность отключить)

// Выбрать сжатие музыки

// Настройки звука и Аудио менеджер должны быть на одном UI

// 0 Эффекты для игрока
// 1 Эффекты со стороны врагов
// 2 Эффекты объектов

// Проверить можно ли изменять музыку вовремя игры
// При переходе на сцену (или локацию) узнаёт какую музыку ему проигрывать
// Будет браться когда будет заходить либо в тригер либо при нажатии кнопки
// Сделать класс, enum + метод которые будут изменятся рукой творца.
// Расчитать Дистанцию до конца уровня и добавить в специальные возможности


// Канвас отключить нельзя, выключить только видимость      // При заходе на сцену и когда игрок нажимает на кнопку //+++++ (17)
// Сделать так чтобы sourceMusic и sourceEffects не отключались, когда я выключаю интерфейс для изменения звука     //+++++ (17)
// Когда перехожу в раздел с музыкой должен включаться курсор для взаимодействия с объектами                        //+++++ (17)
// При нажатии на кнопку паузы чтобы можно было перейти (Включить отображение) в раздел с музыкой

public class AuidioSettings : MonoBehaviour
{
    private Button toggleMusic;      // Чтобы поменять картинку на кнопке
    private Button toggleEffect;

    private Sprite audioOn;    // Музыка включена
    private Sprite audioOff;   // Музыка выключена

    private Slider volumeMusicSlider;     // Регулятор громкости
    private Slider volumeEffectsSlider;     // Регулятор громкости

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

    // Включение/Выключение звука (Громкость остаётся)  || Вызвать одной горячей клавишей или в настройках
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
    public void ToggleConversation()    // Общение 
    {

    }

    public void ToggleSubtitles()       // Субтитры
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