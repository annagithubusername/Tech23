using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantingController : MonoBehaviour
{
   public Sprite bambooIsPlanted;
   public float interactDistance = 2.0f;
   
   private Transform player;
   private SpriteRenderer DirtSpace;

    // Start is called before the first frame update
    void Start()
    {
      player = GameObject.FindGameObjectWithTag("THE PANDA").transform;
        DirtSpace = GetComponent<SpriteRenderer>();  
    }

    // Update is called once per frame
    void Update()
    {

      if (Input.GetKeyDown(KeyCode.B) && IsThePandaNearby())
       {
        PlantBamboo();
       }
    }
    
    bool IsThePandaNearby()

    {
      float distance = Vector2.Distance(transform.position, player.position);
      return distance <= interactDistance;
    }

   void PlantBamboo() 
{
    if (DirtSpace.sprite != bambooIsPlanted)
    {
        DirtSpace.sprite = bambooIsPlanted;
    }
}

}
