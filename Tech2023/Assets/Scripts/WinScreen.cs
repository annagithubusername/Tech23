using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// when players press the main menu button on the game over screen they wil be taken back to the start which is 4 scenes back. 
public class WinScreen : MonoBehaviour
{
   public void Mainmenu()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-4);
   }
}