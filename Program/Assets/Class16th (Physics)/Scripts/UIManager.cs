using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text[] resultText;
    private string[] resultName = { "Victory", "Defeat" };

    private void Awake()
    {
        for (int i = 0; i < resultName.Length; i++)
        {
            resultText[i].text = resultName[i];
        }
    }

    public void Result(string resultName)
    {
        if()
        {

        }
        else if()
        {

        }
    }
}