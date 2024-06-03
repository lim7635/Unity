using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text[] UIText;
    private string[] UIName = { "VICTORY", "DEFEAT" };
    private GameObject text1 = null;
    private GameObject text2 = null;
    public GameManager gameManager;

    private void Awake()
    {
        for (int i = 0; i < UIName.Length; i++)
        {
            UIText[i].text = UIName[i];
        }

        text1 = GameObject.Find("Victory Text");
        text2 = GameObject.Find("Defeat Text");

        text1.SetActive(false);
        text2.SetActive(false);
    }

    void Update()
    {
        if(gameManager.Defeat == true)
        {
            text2.SetActive(true);
        }
        else if (gameManager.State == false)
        {
            text1.SetActive(true);
        }
    }
}