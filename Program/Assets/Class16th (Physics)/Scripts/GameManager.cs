using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool state = true; // ���� ���� ����
    private bool defeat = false; // ���� ���� or ���� ����

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