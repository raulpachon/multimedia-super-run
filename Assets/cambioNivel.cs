using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambioNivel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if( SceneManager.GetActiveScene().buildIndex ==4)
            {
                SceneManager.LoadScene(0);
            }else{
                 SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
                       

        }
    }
}
