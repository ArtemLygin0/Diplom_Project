using UnityEngine;
public class CheckpointProperties : MonoBehaviour
{
    [SerializeField] int progressiv;
    [SerializeField] private TPoint _tpoint;
    private void OnTriggerEnter(Collider other)
    {
        _tpoint.progress = progressiv;
    }
}