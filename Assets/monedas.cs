using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monedas : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
           FindObjectOfType<personaje2>().SendMessage("EcoPoint");
           Destroy(gameObject);
        }
    }
}
