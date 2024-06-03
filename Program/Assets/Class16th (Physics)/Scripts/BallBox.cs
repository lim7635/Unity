using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBox : MonoBehaviour
{
    private int count = 0;
    public int endCount = 2;
    public GameManager gameManager;
    public UIManager uiManager;

    private void OnTriggerEnter(Collider other)
    {
        Ball ball = other.GetComponent<Ball>();

        if(ball != null)
        {
            uiManager.Result("D E F E A T");
            gameManager.State = false;
        }
        else
        {
            count++;

            if(count >= endCount)
            {
                uiManager.Result("V I C T O R Y");
                gameManager.State = false;
            }
        }
    }
}