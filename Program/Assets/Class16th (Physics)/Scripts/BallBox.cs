using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBox : MonoBehaviour
{
    public GameManager gameManager;
    private int count = 0;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Victory"))
        {
            count++;
        }
        else if (other.CompareTag("Defeat"))
        {
            gameManager.State = false;
            gameManager.Defeat = true;
        }

        if(count >= 2)
        {
            gameManager.State = false;
        }
    }
}