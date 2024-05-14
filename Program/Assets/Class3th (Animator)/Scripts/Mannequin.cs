using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mannequin : MonoBehaviour
{
    public int[] data;

    private void Start()
    {
        foreach(int element in data)
        {
            Debug.Log(element);
        }
    }

}