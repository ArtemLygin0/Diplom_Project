using UnityEngine;
using UnityEngine.UI;
public abstract class AbstractSkill : MonoBehaviour
{
    [SerializeField] protected ShopUI shopUI;
    [SerializeField] protected Image image;
    [SerializeField] protected Image[] indicator;
    [SerializeField] protected int currentLVL = 0;
    [SerializeField] protected int price = 30;
    [SerializeField] public bool maxlevel = false;

    public void ConditionUpgrade() // Кнопка
    {
        if (BalanceOfCoins.balance < price || maxlevel) return;
        if (!maxlevel)
        {
            SetColorUpgrade();
            PayingOffBills();
            Upgrade(currentLVL);
        }
        if (currentLVL == 5)
        {
            maxlevel = true;
        }
    }

    private void PayingOffBills()
    {
        currentLVL++;
        BalanceOfCoins.balance -= price;
        shopUI.BalanceTXT.text = $"<color=red>Balance</color> : {BalanceOfCoins.balance}";
    }
    protected void EnoughMoney()
    {
        if (BalanceOfCoins.balance >= price)
            shopUI.BalanceTXT.text = $"Balance : {BalanceOfCoins.balance} - <color=green>{price}</color>";
        else
            shopUI.BalanceTXT.text = $"Balance : {BalanceOfCoins.balance} - <color=red>{price}</color>";
    }

    protected void SetColorUpgrade()
    {
        indicator[currentLVL].color = Color.green;
    }
    protected abstract void Upgrade(int currentLVL);
    public abstract void Description();  
}