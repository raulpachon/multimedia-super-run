using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;


   
public class personaje2 : MonoBehaviour
{
    Rigidbody2D caballeroRB;
    public float maxVelocidad;
    Animator caballeroAnim;
    public bool puedeMover = true;
    public Transform Checker;
    public bool enSuelo = false;
    float chequearRadioSuelo = 0.2f;
    float xInicial;
    float yInicial;
    int vidas = 3;
    int monedas = 0;
    public Text vidast;
    public Text monedast;
    //saltar
    
    public LayerMask capaSuelo;
    public Transform chequearSuelo;
    public float poderSalto;


    //voltear caballero
    bool voltearCaballero = true;
    SpriteRenderer caballeroRender;
        
    // Start is called before the first frame update
    void Start(){
        xInicial = transform.position.x;
        yInicial = transform.position.y;
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

        enSuelo = Physics2D.OverlapCircle(chequearSuelo.position, chequearRadioSuelo, capaSuelo);
        caballeroAnim.SetBool("enSuelo", enSuelo);


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
            caballeroAnim.SetFloat("Horizontal", Mathf.Abs(mover));
            caballeroRB.velocity = new Vector2(mover * maxVelocidad, caballeroRB.velocity.y);
            caballeroAnim.SetFloat("maxVelocidad", Mathf.Abs(mover));

        }
        else
        {
            caballeroRB.velocity = new Vector2(0, caballeroRB.velocity.y);
            caballeroAnim.SetFloat("maxVelocidad", 0);
        }

    }

    void voltear()
    {
        voltearCaballero = !voltearCaballero;
        caballeroRender.flipX = !caballeroRender.flipX;

    }

    void tooglePuedeMover()
    {
        puedeMover = !puedeMover;
    } 
    public void Recolocar()
    {
        transform.position = new Vector2(xInicial,yInicial);
        vidas--;
        vidast.text = vidas.ToString();   
    } 
    public void EcoPoint()
    {
        monedas++;
        monedast.text = monedas.ToString();
   
    } 
}
