using UnityEngine;

public class UP_DOWN : MonoBehaviour
{
    public float t1me = 0;          // Время между кадрами
    public float Amplitude = 0.25f; // +1 блок -1 блок вверх вниз
    public float Freq = 2;          // Частота Прыжков
    public float Offset = 0;        // Смещение
    public Vector3 StartPos;

    private void Start()
    {
        StartPos = transform.position;
    }

    void Update()
    {
        t1me = t1me + Time.deltaTime;
        Offset = Amplitude * Mathf.Sin(t1me * Freq);
        transform.position = StartPos + new Vector3(0, Offset, 0);
        transform.Rotate(new Vector3 (0.15f, 0, 0));
    }
}
