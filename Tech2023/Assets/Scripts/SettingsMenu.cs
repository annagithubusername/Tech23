using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//takes the player back to the menu screen
public class SettingsMenu : MonoBehaviour
{
   public void Back()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-2);
   }
}
