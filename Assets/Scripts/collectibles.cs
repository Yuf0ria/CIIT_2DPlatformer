using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class collectibles : MonoBehaviour
{
    public Animator anim;
    public PlayerMovement player;
    private Vector2 movementInput;
    public float Speed;
    public int health;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
       

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Collectibles"))
        {
            Destroy(collision.gameObject);
            player.moveSpeed += Speed;


        }

        if (collision.gameObject.CompareTag("health"))
        {
            Destroy(collision.gameObject);
            player.healthPoints += health;
        }
    }


}
