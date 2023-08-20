// Увеличивает скорость восстановления способности за каждое улучшение на 1 sec от начального значения.
public class CloudUpgrade : AbstractSkill
{
    public static float cooldown = 6f;
    public static float cloudy = 1f;
    private readonly float startCloudy = 1f;
    private readonly float startCooldown = 6f;
    public override void Description()
    {
        EnoughMoney();
        shopUI.Description.text = $"Description : Increases the ability's cooldown for each upgrade by 1 sec from its base value and increases the duration of the cloud by 0.5 seconds.";
    }

    protected override void Upgrade(int currentLVL) // +++ Кнопка
    {
        cloudy = startCloudy + currentLVL / 2;   // 1 + 5
        cooldown = startCooldown - currentLVL;
    }
}
