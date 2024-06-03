using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool state = true; // 게임 중지 여부
    private bool defeat = false; // 게임 성공 or 실패 여부

    public bool State
    {
        set { state = value; }
        get { return state; }
    }

    public bool Defeat
    {
        set { defeat = value; }
        get { return defeat; }
    }
}