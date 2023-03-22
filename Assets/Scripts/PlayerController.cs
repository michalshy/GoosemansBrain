using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private float vertical;
    private float horizontal;
    private Vector2 velo;
    private Animator playerAnim;
    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
        playerAnim.SetBool("press_d", false);
        playerAnim.SetBool("press_a", false);
        playerAnim.SetBool("press_w", false);

    }

    // Update is called once per frame
    void Update()
    {
        if(horizontal==1)
        {
            playerAnim.SetBool("press_d", true);
            playerAnim.SetBool("press_a", false);
            playerAnim.SetBool("press_w", false);
        }
        else if(horizontal==0)
        {
            playerAnim.SetBool("press_a", false);
            playerAnim.SetBool("press_d", false);
            playerAnim.SetBool("press_w", false);
        }
        else if(horizontal==-1)
        {
            playerAnim.SetBool("press_a", true);
            playerAnim.SetBool("press_d", false);
            playerAnim.SetBool("press_w", false);
        }

        if(vertical==1)
        {
            playerAnim.SetBool("press_w", true);
        }


    }
    void FixedUpdate()
    {
        if(DialogueFreeze.playerFreeze == false)
        {
            vertical = Input.GetAxisRaw("Vertical");
            horizontal = Input.GetAxisRaw("Horizontal");
            velo = new Vector2(horizontal, vertical);
            transform.Translate(velo * speed);
        }
        
    }
}
