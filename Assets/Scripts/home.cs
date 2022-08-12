using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class home : MonoBehaviour
{
    public Text vidas;
    public Text monedas;
    //private  personaje2 PERSON;
    //PERSON = FindObjectOfType<personaje2>();
    public void homeGo()
    {
     SceneManager.LoadScene(0); 
    }
    public void Skip()
    {
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
    }
   // public void update(){

   // vidas.text = PERSON.vidas.toString();
   // monedas.text = PERSON.monedas.toString();
    
    //}
}


