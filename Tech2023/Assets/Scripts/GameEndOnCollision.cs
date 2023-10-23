using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEndOnCollision : MonoBehaviour
{
    public LayerMask fire;          // Layer for the enemy character

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected"); // Debugging

        // Check if the collision involves an object on the enemyLayer
        if (((1 << collision.gameObject.layer) & fire) != 0)
        {
            Debug.Log("Collision with fire character"); // Debugging

            // Load the next scene
            int nextSceneBuildIndex = SceneManager.GetActiveScene().buildIndex + 2;
            Debug.Log("Loading scene with build index: " + nextSceneBuildIndex); // Debugging

            SceneManager.LoadScene(nextSceneBuildIndex);
        }
    }
}
