﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityAnimator : MonoBehaviour
{

    Rigidbody rb;
    Animator animator;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Velocity", rb.velocity.magnitude);
    }
}
