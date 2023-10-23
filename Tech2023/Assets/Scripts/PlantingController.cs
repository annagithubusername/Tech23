using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlantingController : MonoBehaviour
{
  //A public variable that references the sprite ofr the planted bamboo
   public Sprite bambooIsPlanted; 
   //The value of distance which determines when the bammboo can be planted
   public float interactDistance = 2.0f;
   
   private Transform player;
   
   
   
  private int bambooNum = 0;
  public TextMeshProUGUI textBamboo;


    // Start is called before the first frame update
    void Start()
    {
      player = GameObject.FindGameObjectWithTag("THE PANDA").transform;  //This finds the Transform for the player with the tag "THE PANDA"
     
    
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
    }
    //Checks if the panda is close
    bool IsThePandaNearby()

    {Collider2D[] hitColliders = Physics2D.OverlapCircleAll(player.position, interactDistance);

        foreach (Collider2D col in hitColliders)
        {
            if (col.gameObject.CompareTag("Dirt Patch"))
            {
                return true;
            }
        }

        return false;
    }

 
   void PlantBamboo() //Plants bamboo
 {
        Collider2D[] hitColliders = Physics2D.OverlapCircleAll(player.position, interactDistance);

        foreach (Collider2D col in hitColliders)
        {
            if (col.gameObject.CompareTag("Dirt Patch") && col.GetComponent<SpriteRenderer>().sprite != bambooIsPlanted)
            {
                col.GetComponent<SpriteRenderer>().sprite = bambooIsPlanted;
                bambooNum++;
                textBamboo.text = bambooNum.ToString();
                Debug.Log("Bamboo planted on dirt patch. Count: " + bambooNum);
            }
        }
    }
}
