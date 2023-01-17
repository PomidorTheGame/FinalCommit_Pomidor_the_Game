using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    public Animator anim;
    public GameObject objekt;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }
    void TakeDamage()
    {
        currentHealth -= 1;
        if (currentHealth == 0)
        {
            anim.SetBool("IsDead", true);
            Invoke("cleanup",0.4f);
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "bullet")
        {
            TakeDamage();
        }
    }
    private void cleanup()
    {
        Destroy(objekt);
    }
   
}
