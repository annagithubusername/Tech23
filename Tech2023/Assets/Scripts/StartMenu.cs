using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
   public void play()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
   }
   public void settings()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+2);
   }
}
