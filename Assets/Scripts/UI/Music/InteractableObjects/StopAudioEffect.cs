using UnityEngine;

// Останавливает музыку на конкретном объекте
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
