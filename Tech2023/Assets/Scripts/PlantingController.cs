using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlantingController : MonoBehaviour
{
  //A public variable that references the sprite ofr the planted bamboo
   public Sprite bambooIsPlanted; 
   //The value of distance which determines when the bammboo can be planted
   public float interactDistance = 2.0f;
   
   private Transform player;
   
   
   /*The bamboo counter value at the start of the game*/
  private int bambooNum = 0;
  public TextMeshProUGUI textBamboo;


    // Start is called before the first frame update
    void Start()
    {
       //This finds the Transform for the player with the tag "THE PANDA"
      player = GameObject.FindGameObjectWithTag("THE PANDA").transform; 
     
    
    }

    // Update is called once per frame
    void Update()
    {
      
      // Checks if the "B" key has been pressed when panda is close to dirt
      if (Input.GetKeyDown(KeyCode.B) && IsThePandaNearby())
       { 
        PlantBamboo(); //Calls this function to plant the bamboo
        Debug.Log("PlantBamboo called");    
       }
      if (bambooNum >= 7)
     
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    //Checks if the panda is close
    bool IsThePandaNearby()
    /*Uses Physics2D to find all the colliders that happen to be in a circular area around the around thepanda player*/
    {Collider2D[] hitColliders = Physics2D.OverlapCircleAll(player.position, interactDistance);

      // In a way Sorts through all the colliders found in the circular area around the player
        foreach (Collider2D col in hitColliders)
        {
            //Checks if the gameobject close by has the "Dirt Patch" tag
            if (col.gameObject.CompareTag("Dirt Patch"))
            {
                return true; // Means that the panda is near a dirt patch 
            }
        }

        return false; // Means that the panda is not near a dirt patch 
    }

 
   void PlantBamboo() //Plants bamboo
 {
  /*Uses Physics2D to find all the colliders that happen to be in a circular area around the around thepanda player*/
        Collider2D[] hitColliders = Physics2D.OverlapCircleAll(player.position, interactDistance);

        foreach (Collider2D col in hitColliders)
        {
          // This checks if the gameobject close by has the tag "Dirt Patch" and whether it is already planted with bamboo
            if (col.gameObject.CompareTag("Dirt Patch") && col.GetComponent<SpriteRenderer>().sprite != bambooIsPlanted)
            {
              // Sets the sprite of the dirt patch to be planted with the bamboo
                col.GetComponent<SpriteRenderer>().sprite = bambooIsPlanted;
                //Increases the bammboo count number
                bambooNum++;
                //links it all to the text
                textBamboo.text = bambooNum.ToString();
                Debug.Log("Bamboo planted on dirt patch. Count: " + bambooNum);
            }
        }
    }
}
