using UnityEngine;
using UnityEngine.UI;

public class TextFactChanger : MonoBehaviour
{
    public Text textElement; // Reference to the Text element in the Canvas
    public string[] factsPool;  // An array of different facts
    private string currentFact; // The currently displayed fact

    private void Start()
    {
        if (textElement == null)
        {
            Debug.LogError("Text element is not assigned!");
        }
        else
        {
            // Initialize with a random fact from the pool
            DisplayRandomFact();
        }
    }

    private void Update()
    {
        // Check if the "B" key is pressed
        if (Input.GetKeyDown(KeyCode.B))
        {
            // Display a new random fact from the pool
            DisplayRandomFact();
        }
    }

    private void DisplayRandomFact()
    {
        if (factsPool != null && factsPool.Length > 0)
        {
            // Choose a random fact from the pool
            int randomIndex = Random.Range(0, factsPool.Length);
            currentFact = factsPool[randomIndex];

            // Update the Text element with the new fact
            textElement.text = currentFact;
        }
    }
}
