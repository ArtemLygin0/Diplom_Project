// Увеличивает прыжок за каждое улучшение на 5% от начального значения
public class JumpUpgrade : AbstractSkill
{
    private readonly float startJump = 300f;
    public override void Description()
    {
        EnoughMoney();
        shopUI.Description.text = $"Description : Increases jump for each upgrade by 5 % of base value.";
    }

    protected override void Upgrade(int currentLVL)
    {
        PlayerController.jumpForce = startJump * (1 + currentLVL * 0.05f);   // 300 * (1 + 3 * 0.05)
    }
}