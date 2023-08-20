using UnityEngine;

// ����������� ������ � ����
// ��� ������� �� ������� �������� ����� � �������

// ���� ������ ����� ������������� ������������ ������ 
// ���� ����� ������������ �������������

// ����� � ��������� �� �������

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

        // �������� ���� ������ ���������� � ����������
        //TheCamera_0.enabled = !TheCamera_0.enabled;
        //Cam_0.enabled = !Cam_0.enabled;
    }
}
//������ ��� ������ ����
//TheCamera_0.GetComponent<AudioListener>().enabled = !TheCamera_0.GetComponent<AudioListener>().enabled;
//Cam_0.GetComponent<AudioListener>().enabled = !Cam_0.GetComponent<AudioListener>().enabled;
