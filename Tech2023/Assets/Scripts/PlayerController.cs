using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    //set the player move speed
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
        
        //isMoving is a animator that controls when an animation runs depending on its horiontal and vertical movement(Daphne)
         isMoving.SetFloat("Horizontal", movementDir.x); //sets the horizontal parameter to move left and right(Daphne) 
         isMoving.SetFloat("Vertical", movementDir.y); //sets the parameter float to move up and down (Daphne)
         isMoving.SetFloat("Speed", movementDir.sqrMagnitude); //calculates the squared magnitude of the vector called movementDir (Daphne)
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
    
    //when the fire character collides with the panda the game over scene will load. (Anna)
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("theFire"))
        {
            SceneManager.LoadScene("GameOver");
        }
    }

}