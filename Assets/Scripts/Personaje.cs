using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    Rigidbody2D caballeroRB;
    public float maxVelocidad;
    Animator caballeroAnim;
    bool puedeMover = true;

    //saltar
    bool enSuelo = false;
    float chequearRadioSuelo = 0.2f;
    //public LayerMask capaSuelo;
    //public Transform chequearSuelo;
    public float poderSalto;


    //voltear caballero
    bool voltearCaballero = true;
    SpriteRenderer caballeroRender;
        
    // Start is called before the first frame update
    void Start(){
        caballeroRB = GetComponent<Rigidbody2D> ();
        caballeroRender = GetComponent<SpriteRenderer> ();
        caballeroAnim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

    if (puedeMover && enSuelo && Input.GetAxis("Jump") >0)
        {
            caballeroAnim.SetBool("enSuelo", false);
            caballeroRB.velocity = new Vector2(caballeroRB.velocity.x, 0f);
            caballeroRB.AddForce(new Vector2(0, poderSalto),ForceMode2D.Impulse);
            enSuelo = false;
        }

        //enSuelo = Physics2D.OverlapCircle(chequearSuelo.position, chequearRadioSuelo, capaSuelo);
       // caballeroAnim.SetBool("enSuelo", enSuelo);


        float mover = Input.GetAxis("Horizontal");


        if (puedeMover)
        {
            if (mover > 0 && !voltearCaballero)
            {
                voltear();

            }
            else if (mover < 0 && voltearCaballero)
            {
                voltear();
            }

            caballeroRB.velocity = new Vector2(mover * maxVelocidad, caballeroRB.velocity.y);
            caballeroAnim.SetFloat("VelMovimiento", Mathf.Abs(mover));

        }
        else
        {
            caballeroRB.velocity = new Vector2(0, caballeroRB.velocity.y);
            caballeroAnim.SetFloat("VelMovimiento", 0);
        }

    }

    void voltear()
    {
        voltearCaballero = !voltearCaballero;
        caballeroRender.flipX = !caballeroRender.flipX;

    }

    public void tooglePuedeMover()
    {
        puedeMover = !puedeMover;
    }

   
}
