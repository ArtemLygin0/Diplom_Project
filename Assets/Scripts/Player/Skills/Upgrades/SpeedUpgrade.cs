// ����������� �������� �� ������ ��������� �� 10% �� ���������� ��������
public class SpeedUpgrade : AbstractSkill
{
    private readonly float startSpeed = 6f;
    public override void Description()
    {
        EnoughMoney();
        shopUI.Description.text = $"Description : Increases speed for each upgrade by 10% of base value.";
    }

    protected override void Upgrade(int currentLVL)
    {
        PlayerController.speed = startSpeed * (1 + currentLVL * 0.10f);   // 6 * 1.1 =  6.6
    }
}