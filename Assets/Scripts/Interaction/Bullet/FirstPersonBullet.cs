using UnityEngine;

// Переключает камеры и звук
// При нажатии на клавишу стреляет пулей с камерой

// Пуля должна уметь просматривать пространство вокруг 
// Пуля может перемещаться пользователем

// Фишка с переходом на функцию

public class FirstPersonBullet : MonoBehaviour
{
    [SerializeField] private Camera TheCamera;
    [SerializeField] private Camera Cam;

    [SerializeField] private AudioListener TheCamera_0;
    [SerializeField] private AudioListener Cam_0;

    private void Awake()
    {
        TheCamera_0 = GetComponent<AudioListener>();
        Cam_0 = GetComponent<AudioListener>();
    }

    private void Start()
    {
        TheCamera = GetComponent<Camera>();
        TheCamera = Camera.main;
    }

    public void switchCam()
    {
        TheCamera.enabled = !TheCamera.enabled;
        Cam.enabled = !Cam.enabled;

        // Работает если заново подключить в инспекторе
        //TheCamera_0.enabled = !TheCamera_0.enabled;
        //Cam_0.enabled = !Cam_0.enabled;
    }
}
//Пример как делать низя
//TheCamera_0.GetComponent<AudioListener>().enabled = !TheCamera_0.GetComponent<AudioListener>().enabled;
//Cam_0.GetComponent<AudioListener>().enabled = !Cam_0.GetComponent<AudioListener>().enabled;
