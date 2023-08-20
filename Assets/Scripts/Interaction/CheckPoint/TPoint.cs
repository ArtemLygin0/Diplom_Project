using UnityEngine;
public class TPoint : MonoBehaviour
{
    [SerializeField] public GameObject player;
    [SerializeField] public Transform[] Tpoint;
    public int progress = 0;
    
    public void Teleportik()
    {
        player.transform.position = Tpoint[progress].transform.position;
    }
    /*
    public void Teleportik(GameObject player)
    {
        player.transform.position = Tpoint[progress].transform.position;
    }
    */
}