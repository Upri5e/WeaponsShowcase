using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Hand : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void SetGrip(float v)
    {
        animator.SetFloat("Grip", v);
    }

    public void SetTrigger(float v)
    {
        animator.SetFloat("Trigger", v);
    }
}
