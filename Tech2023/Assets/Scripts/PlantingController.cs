using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantingController : MonoBehaviour
{
  //A public variable that references the sprite ofr the planted bamboo
   public Sprite bambooIsPlanted; 
   //The value of distance which determines when the bammboo can be planted
   public float interactDistance = 2.0f;
   
   private Transform player;
   private SpriteRenderer DirtSpace;
   


    // Start is called before the first frame update
    void Start()
    {
      player = GameObject.FindGameObjectWithTag("THE PANDA").transform;  //This finds the Transform for the player with the tag "THE PANDA"
      DirtSpace = GetComponent<SpriteRenderer>(); //stores the dirt
      
    }

    // Update is called once per frame
    void Update()
    {
      // Checks if the "B" key has been pressed when panda is close to dirt
      if (Input.GetKeyDown(KeyCode.B) && IsThePandaNearby())
       { 
        PlantBamboo(); //Calls this function to plant the bamboo
       }
    }
    //Checks if the panda is close
    bool IsThePandaNearby()

    {
      float distance = Vector2.Distance(transform.position, player.position); // does the calculation of distance between the dirt and panda
      return distance <= interactDistance; //Basically confirms if panda is in correct range
    }

   void PlantBamboo() //Plants bamboo
{
    if (DirtSpace.sprite != bambooIsPlanted)//Checks if the closest dirt has alreay been planted  
    {
      //Switches the dirt sprite with the planted bamboo sprite
        DirtSpace.sprite = bambooIsPlanted;
    }
}
    

}
