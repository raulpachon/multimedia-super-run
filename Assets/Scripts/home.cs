using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class home : MonoBehaviour
{
    public void homeGo()
    {
     SceneManager.LoadScene(0); 
    }
    public void Skip()
    {
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
    }
}
