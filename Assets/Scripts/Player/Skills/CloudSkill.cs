using UnityEngine;

public class CloudSkill : MonoBehaviour
{
    [Header("������")]
    private PlayerController _playerController;
    //[SerializeField] private CloudUpgrade _cloudUpgrade;
    [Header("�������")]
    [SerializeField] public GameObject Cube;
    private bool isCooldown = false;
    private float time = 0;

    private void Awake()
    {
        _playerController = GetComponent<PlayerController>();
    }

    private void Update()
    {
        if (isCooldown == true)
        {
            time += Time.deltaTime;
        }
    }

    public void ConditionCloud()
    {
        if (time >= CloudUpgrade.cooldown)
        {
            time = 0;
            isCooldown = false;
        }

        if (time == 0)  // ��������� ������
        {
            isCooldown = true;
            UseCloud();
        }
    }

    public void UseCloud()
    {
        GameObject cloudlet = Instantiate(Cube, transform.position, Quaternion.identity);
        Destroy(cloudlet, CloudUpgrade.cloudy);
        Invoke("IsGrounded", CloudUpgrade.cloudy);
    }

    private void IsGrounded()
    {
        _playerController.isGrounded = false;
    }

    public void TimerSkill()
    {
        if (isCooldown == true)
        {
            time += Time.deltaTime;
        }
    }

}
