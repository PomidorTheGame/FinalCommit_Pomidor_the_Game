using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
  
    private float jumpingPower = 16f;
    
    private float dirX;
    public float moveSpeed;
    public Animator animator;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
   

    
        
    
    // Update is called once per frame
    void Update()
    {
        //szybkoœæ poryszania sie 
        //moveSpeed = 5f;

        horizontal = Input.GetAxisRaw("Horizontal");
        
        //skok 
        if(Input.GetKeyDown("up") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
            
        }
        if (Input.GetKeyUp("up") && rb.velocity.y > 0f)
       {
           rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
            
       }
        
        
        
        Roll();
    }

    private void FixedUpdate() 
    {
        //powoduje ¿e postaæ idzie w prawo albo w lewo sama z siebie
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);
    }

    private void Roll()//odpowiada za kierunek poruszania sie pomidora;
    {
        //wybór kierunku rolla w lewo
        if (((Input.GetButtonDown("Horizontal")) && (Input.GetKey("left"))) && IsGrounded())
        {
            dirX = -1f;
            animator.SetInteger("speed", -1);
          
        }
        //wybór kierunku rolla w prawo
        if (((Input.GetButtonDown("Horizontal")) && (Input.GetKey("right"))) && IsGrounded())
        {
            dirX = 1f;
            animator.SetInteger("speed", 1);
        
        }
    } 
   

    private bool IsGrounded()//sprawdza czy pomidor dotyka ziemi;
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

   
    
}
