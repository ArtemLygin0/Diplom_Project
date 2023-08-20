using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float _mouseX;
    private float _mouseY;
    private float _xRotation = 0f;

    [SerializeField] private float _mouseSensivity = 1200f;
    [SerializeField] private Transform _Player;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        _mouseX = Input.GetAxis("Mouse X") * _mouseSensivity * Time.deltaTime;
        _mouseY = Input.GetAxis("Mouse Y") * _mouseSensivity * Time.deltaTime;

        _xRotation -= _mouseY;
        _xRotation = Mathf.Clamp(_xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(_xRotation, 0, 0);
        _Player.Rotate(Vector3.up * _mouseX);
    }
}
