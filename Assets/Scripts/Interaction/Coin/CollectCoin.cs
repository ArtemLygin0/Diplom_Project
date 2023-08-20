using UnityEngine;

// Подбор монеты, присваивается на каждую монету
public class CollectCoin : MonoBehaviour
{
    [SerializeField] private LevelUI _levelUI;
    [SerializeField] private int numberOfCoin;
    private CoinAudio coinAudio;

    private void Start()
    {
        coinAudio = GetComponent<CoinAudio>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            GetCoinFromLevel(_levelUI.currentLevel, numberOfCoin);
            coinAudio.TryInteract();
            Destroy(gameObject);
        }
    }

    /// <summary>
    /// Собирает монету на уровне и сохраняет в <Баланс>
    /// </summary>
    /// <param name="currentLevel"></param>
    /// <param name="numberOfCoin"></param>
    public void GetCoinFromLevel(int currentLevel, int numberOfCoin)
    { 
        if (GameInfo.savedCoins[currentLevel, numberOfCoin] == true) return;    // Если монета собрана (показать другой префаб монеты), (не прибавлять к балансу)
        GameInfo.savedCoins[currentLevel, numberOfCoin] = true;

        _levelUI.coins++;
        _levelUI._coinText.text = "Coins : " + _levelUI.coins;
        BalanceOfCoins.balance++;  
    }
}