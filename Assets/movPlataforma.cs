using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movPlataforma : MonoBehaviour
{
        [SerializeField]private float velocidad;
        [SerializeField]private Transform controlSuelo;
        [SerializeField]private float distancia;
        [SerializeField]private bool movDerechos;
        private Rigidbody2D rb ;
   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FileUpdate()
    {
        RaycastHit2D infoSuelo = Physics2D.Raycast(controlSuelo.position, Vector2.down , distancia);
        rb.velocity = new Vector2(velocidad,rb.velocity.y);
        if(infoSuelo== false){
            Girar();
        }
    }
    private void Girar(){
        
        movDerechos= !movDerechos;
        transform.eulerAngles = new Vector3(0,transform.eulerAngles.y  + 180, 0);
        velocidad*=-1;

    }
    private void OnDrawGizmos(){
        Gizmos.color = Color.red;
        Gizmos.DrawLine( controlSuelo.transform.position, controlSuelo.transform.position+Vector3.down*distancia);
    }
}
