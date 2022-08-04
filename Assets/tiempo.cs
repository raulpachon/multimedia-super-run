using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tiempo : MonoBehaviour
{
   public float timerbb = 0;
    void Update()
    {
       timerbb -= Time.deltaTime;
       if(timerbb<0){
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
       } 
    }
}
