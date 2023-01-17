using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flying_enemy_Script : MonoBehaviour
{
    public float speed;
    public bool chase = false;
    public Transform startingPoint;
    public GameObject player;
    public Animator anim;
     
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
            return;
        if (chase == true)
        {
            Chase();
            
        }
        else
        {
            Return();   
        }
        
         //   anim.SetBool("Flight", false);
       
        Flip();

    }

    private void Chase()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        anim.SetBool("Flight", true);
    }
    
    private void Return()
        {
            transform.position = Vector2.MoveTowards(transform.position, startingPoint.position, speed * Time.deltaTime);
      
                   
    }
    private void Flip()
    {
        if (transform.position.x > player.transform.position.x)
            transform.rotation = Quaternion.Euler(0, 180, 0);
        else
            transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
