using UnityEngine;

public sealed class PlayerController : MonoBehaviour
{
    [SerializeField] public GameObject Player;
    private DieClass _dieClass;
    private CloudSkill _cloudSkill;

    [Header("����������� ���������")]
    [SerializeField] public int lives = 5;
    [SerializeField] private float runSpeed = 9f;
    public static float speed = 6f; //статика, плохая практика, делает сильную связанность и спагетти стайл
    public static float jumpForce = 300f;

    public bool isGrounded;
    public Rigidbody rb;

    private void Awake()
    {
        _dieClass = GetComponent<DieClass>();
        _cloudSkill = GetComponent<CloudSkill>();
    }

    /*
    public void Start()
    {
        lives = PlayerPrefs.GetInt("Lives");
    }
    */
    void Update()
    {
        GetInput();
    }

    private void GetInput()
    {
        if (Input.anyKey)
        {
            //Много дубликата кода, делается в одну строчку
            transform.position = new Vector3(Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal"))
                                 * ((Input.GetKey(KeyCode.LeftShift) ? runSpeed : speed) * Time.deltaTime);
            // if (Input.GetKey(KeyCode.W))
            // {
            //     if (Input.GetKey(KeyCode.LeftShift))
            //         transform.localPosition += transform.forward * runSpeed * Time.deltaTime;
            //     else
            //         transform.localPosition += transform.forward * speed * Time.deltaTime;
            // }
            //
            // if (Input.GetKey(KeyCode.A))
            // {
            //     if (Input.GetKey(KeyCode.LeftShift))
            //         transform.localPosition += -transform.right * runSpeed * Time.deltaTime;
            //     else
            //         transform.localPosition += -transform.right * speed * Time.deltaTime;
            // }
            //
            // if (Input.GetKey(KeyCode.S))
            // {
            //     if (Input.GetKey(KeyCode.LeftShift))
            //         transform.localPosition += -transform.forward * runSpeed * Time.deltaTime;
            //     else
            //         transform.localPosition += -transform.forward * speed * Time.deltaTime;
            // }
            //
            // if (Input.GetKey(KeyCode.D))
            // {
            //     if (Input.GetKey(KeyCode.LeftShift))
            //         transform.localPosition += transform.right * runSpeed * Time.deltaTime;
            //     else
            //         transform.localPosition += transform.right * speed * Time.deltaTime;
            // }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (isGrounded)
                    rb.AddForce(transform.up * jumpForce);
            }

            if (Input.GetKeyDown(KeyCode.Q))
            {
                _dieClass.Die();
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                _cloudSkill.ConditionCloud();
                // ������� ���-�� �������
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            isGrounded = true;

        if (collision.gameObject.CompareTag("KillCollider"))
        {
            _dieClass.Die();
            //PlayerPrefs.SetInt("Lives", lives);
            //PlayerPrefs.DeleteKey("Lives");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            isGrounded = false;
    }
}