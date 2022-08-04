using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Camara : MonoBehaviour
    
{   public GameObject jugador;
    Vector3 distancia;
    private Transform theTransfomr;
    public Vector2 Hrange = Vector2.zero;
    public Vector2 Vrange = Vector2.zero;


    // Start is called before the first frame update
    void Start()
    {
       distancia = transform.position - jugador.transform.position;
       theTransfomr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = jugador.transform.position + distancia; 
    }
    void LateUpdate()
    {
       theTransfomr.position = new Vector3(
         Mathf.Clamp(transform.position.x,Vrange.x,Vrange.y),
        Mathf.Clamp(transform.position.y,Hrange.x,Hrange.y),
       transform.position.z);
    }
}
