using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ItemCollector : MonoBehaviour
{
    public GameObject kropelka;
    [SerializeField] float punkty;

    [SerializeField] TMP_Text kropelki_txt;
   
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.tag == "Player")
            {
                Destroy(kropelka);
            
            kropelki_txt.text = "Punkty: " + punkty;
            }
        }
}

    

