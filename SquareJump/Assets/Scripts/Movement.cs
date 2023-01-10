using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public StateManager stageManage;
    public MusicManager music;
    public int speed;
    public int jumpForce;
    public bool grounded;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkGrounded();
        checkFly();
        if (Input.touchCount > 0)
        {
            if (grounded && stageManage.state == "Playing")
            {
                Jump();
            }
        }
    }
    void FixedUpdate()
    {
        if (stageManage.state == "Playing")
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
    public void resetGravity(int x)
    {
        rb.gravityScale = x;
    }
    public void Jump()
    {
        music.PlayJump();
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }
/*    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Mat dat"))
        {
            grounded = true;
        }
    }*/
    void checkGrounded()
    {
        if (transform.position.y <= -2f && transform.position.y > -2.3f)
        {
            grounded = true;
        }
    }
    void checkFly()
    {
        if (transform.position.y > -2f || transform.position.y <= -2.4f)
        {
            grounded = false;
        }
    }
/*    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Mat dat"))
        {
            grounded = false;
        }
    }*/ 
}
