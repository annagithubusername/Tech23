using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //player move speed
    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    public Vector2 movementDir;

    //random
    // Start is called before the first frame update
    void Start()
    {
       //use get compenent method to assing the rigid body
       rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        // set movementDir to 0 when not pressing any keys
        movementDir = Vector2.zero;
        //get horizontal axis from unity
        movementDir.x = Input.GetAxisRaw("Horizontal");
        //get veritical axis from unity
        movementDir.y = Input.GetAxisRaw("Vertical");
    }
    //this is called every 50 frames
    private void FixedUpdate()
    {
        //the move player function
       MovePlayer();
    }

    public void MovePlayer()
    {
        //to move we need a start position, new direction, movespeed and time
         rb.MovePosition(rb.position + movementDir * moveSpeed * Time.fixedDeltaTime);
    }
}