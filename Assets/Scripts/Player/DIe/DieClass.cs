using UnityEngine;

public class DieClass : MonoBehaviour
{
    private PlayerController _playerController;
    [SerializeField] private TPoint _tpoint;
    [SerializeField] private SceneLoader _sceneLoader;
    [SerializeField] public GameObject Cube;

    [SerializeField] private UIAchievement _UIAchievement;

    private void Awake()
    {
        _playerController = GetComponent<PlayerController>();
    }

    public void Die(bool bluelaser = false)
    {
        if (_playerController.lives > 0)
        {
            _playerController.lives--;
            if (!bluelaser) // -1 жизнь, но не спавнит блок
            {
                Instantiate(Cube, transform.position, Quaternion.identity);
            }
            _tpoint.Teleportik();
        }
        else
        {
            Debug.Log("GameOver");
            Destroy(gameObject);
            _sceneLoader.LoadScene();
        }

       //_UIAchievement.SelectAchievement(/*_UIAchievement.achievement*/);
    }
}
