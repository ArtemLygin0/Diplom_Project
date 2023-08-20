using UnityEngine;

// ������������� ������ �� ���������� �������
public class StopAudioEffect : MonoBehaviour
{
    [SerializeField] private CoinAudio coin;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (coin != null)
            {
                coin.loop = false;
                coin.StopAudioEffect();
            }
        }
    }
}
