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
    }
}
