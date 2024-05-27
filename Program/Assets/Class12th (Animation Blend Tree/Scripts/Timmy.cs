using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Timmy : MonoBehaviour
{
    private Animator animator;
    private Vector3 direction;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        animator.SetFloat("X", direction.x);
        animator.SetFloat("Y", direction.z);
    }
}