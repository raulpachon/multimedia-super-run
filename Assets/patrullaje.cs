using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrullaje : MonoBehaviour
{
    public float vel;
    private Rigidbody2D rb ;
    //private  personaje2 PERSON;

    //PERSON = FindObjectOfType<personaje2>();
   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(vel,rb.velocity.y);
    }

    private void OnTriggerExit2D(Collider2D otro){
        if(otro.gameObject.tag=="plataforma")
        {
            vel *= -1;
            this.transform.localScale = new Vector2(this.transform.localScale.x*-1, this.transform.localScale.y);
        }
         if(otro.gameObject.tag=="Player")
        {
            Destroy(gameObject);
            FindObjectOfType<personaje2>().SendMessage("Recolocar");
        }
    }

}
