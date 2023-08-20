using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField] LaserAudio laserAudio;
    private int count = 0;
    public void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W) && count < 3)
        { 
            count++;
            Music();
        }
    }

    private void Music()
    {
        if (count == 1)
            laserAudio.TryInteract();
    }
}
