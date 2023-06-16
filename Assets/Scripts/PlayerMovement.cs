using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{

    //Player Speed
    public float moveSpeed;
    //rigidBody
    public Rigidbody2D rigidBody;
    //how the player moves
    private Vector2 movementInput;
    //Access Animator to play animations
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) 
        {
            anim.SetTrigger("BackwardAnimation");
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetTrigger("BackwardAnimationPause");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetTrigger("ForwardAnimation");
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetTrigger("ForwardAnimationPause");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetTrigger("LeftAnimation");
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetTrigger("LeftAnimationPause");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetTrigger("RightAnimation");
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetTrigger("RightAnimationPause");
        }
    }

    private void FixedUpdate()
    {
        rigidBody.velocity = movementInput * moveSpeed;
    }

    //InputSystem Clicks
    private void OnMove(InputValue inputValue)
    {
        movementInput = inputValue.Get<Vector2>();
    }
}
