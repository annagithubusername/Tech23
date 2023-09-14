using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //player move speed
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator isMoving; //(Daphne)

    public Vector2 movementDir;

    
    // Start is called before the first frame update (Anna)
    void Start()
    {
       //using get compenent method to assign the rigid body (Anna)
       rb = GetComponent<Rigidbody2D>(); 
      
    }

    // Update is called once per frame (Anna)
    void Update()
    {
        // set movementDir to 0 when not pressing any keys (Anna)
        movementDir = Vector2.zero;
        //get horizontal axis from unity (Anna)
        movementDir.x = Input.GetAxisRaw("Horizontal");
        //get veritical axis from unity (Anna)
        movementDir.y = Input.GetAxisRaw("Vertical");
        
         isMoving.SetFloat("Horizontal", movementDir.x); //(Daphne)
         isMoving.SetFloat("Vertical", movementDir.y); //(Daphne)
         isMoving.SetFloat("Speed", movementDir.sqrMagnitude); //(Daphne)
    }
    //this is called every 50 frames (Anna)
    private void FixedUpdate()
    {
        //the move player function (Anna)
       MovePlayer();

    }

    public void MovePlayer()
    {
        //start position, new direction, movespeed and time (Anna)
         rb.MovePosition(rb.position + movementDir * moveSpeed * Time.fixedDeltaTime);
    }
}