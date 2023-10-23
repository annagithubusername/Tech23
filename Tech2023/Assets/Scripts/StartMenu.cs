using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
   //takes the player to the intruction pages
   public void play()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
   }
   //takes the player to the settings page
   public void settings()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+2);
   }
}
