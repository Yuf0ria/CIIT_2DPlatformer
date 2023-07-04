using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    public PlayerMovement player;
    public int trapDamage;
    public bool isPlayeronTop;

    void Start()
    {
        anim= GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isPlayeronTop = true;

        if (collision.gameObject.CompareTag("Player"))
        {
            anim.SetBool("Isactive", true);

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isPlayeronTop= false;


        if (collision.gameObject.CompareTag("Player"))
        {
            anim.SetBool("Isactive", false);
        }
    }

    public void PlayerDamage()
    {
        if (isPlayeronTop)
        {
            player.healthPoints -= trapDamage;
        }
        
    }
}
