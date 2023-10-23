using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{// when players press the main menu button on the game over screen they wil be taken back to the start which is 5 scenes back. 
   public void Mainmenu()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-5);
   }
}