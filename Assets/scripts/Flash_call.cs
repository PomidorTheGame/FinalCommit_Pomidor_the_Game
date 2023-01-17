using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash_call : MonoBehaviour
{
    [SerializeField] private SpriteFlash flashEffect;
    //[SerializeField] private KeyCode flashKey;

    private void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("bullet"))
        {
            flashEffect.Flash();
        }
    }
 }
