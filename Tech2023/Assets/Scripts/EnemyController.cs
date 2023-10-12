using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;
    
    private Transform PandaPlayer;
   
    // Start is called before the first frame update
    void Start()
    {
       PandaPlayer = GameObject.FindGameObjectWithTag("THE PANDA").GetComponent<Transform>(); 
    }

    // Update is called once per frame
    void Update()
    {
      transform.position = Vector2.MoveTowards(transform.position, PandaPlayer.position, speed * Time.deltaTime);  
      //calculates the horizontal direction and determines which way the fire needes to face
      float horizontalDirection = Mathf.Sign(PandaPlayer.position.x - transform.position.x);

if (horizontalDirection > 0.01)
 // Flip the character to face right
   transform.localScale = new Vector2(-5,5);
 // Flip the character to face left
   else if (horizontalDirection < -0.01)
   transform.localScale  = new Vector2(5,5);  
    }
}

