using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MovementNew : MonoBehaviour
{
    public CharacterController2D controller;
    public float speed = 40f;
    public Animator animation;

    private float horizontalMove = 0f;
    bool jump = false;
    


    // Start is called before the first frame update
    
    //nafi editing below
    
    private void Start()
    {
        
    } 

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal") * speed;
        animation.SetFloat("Run",Math.Abs(horizontalMove));
       
        animation.SetBool("Jump1",jump);
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove*Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}


