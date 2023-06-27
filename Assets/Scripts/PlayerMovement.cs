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
    public int coinsCount;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        //{
        //    anim.enabled= true;
        //    anim.SetTrigger("BackwardAnimation");
        //}
        //if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        //{
        //    anim.SetTrigger("ForwardAnimation");
        //    anim.enabled = true;
        //}
        //if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        //{
        //    anim.enabled = true;
        //    anim.SetTrigger("LeftAnimation");
        //}
        //if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //    anim.enabled = true;
        //    anim.SetTrigger("RightAnimation");
        //}
        //if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.W))
        //{
        //    anim.enabled= false;
        //}
        anim.SetFloat("Horizontal", movementInput.x);
        anim.SetFloat("Vertical", movementInput.y);
        anim.SetFloat("speed", movementInput.sqrMagnitude);


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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Coins"))
        {
            Destroy(collision.gameObject);
            coinsCount++;
        }
    }
}
