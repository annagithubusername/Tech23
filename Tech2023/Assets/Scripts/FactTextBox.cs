using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

 

public class FactTextBox : MonoBehaviour
{
    public TextMeshProUGUI animalFactsText;
    private List<string> animalFacts = new List<string>();
    private int currentFactIndex = -1;

 

    private void Start()
    {
        // pool of deforestation facts.
        animalFacts.Add("Elephants are the largest land animals.");
        animalFacts.Add("Dolphins are highly intelligent marine mammals.");
        animalFacts.Add("Tigers are the largest species of big cats.");
        animalFacts.Add("Penguins are excellent swimmers.");

 

        // Make sure the TextMeshProUGUI component is assigned in the inspector.
        if (animalFactsText == null)
        {
            Debug.LogError("TextMeshProUGUI component not assigned!");
        }
        else
        {
            animalFactsText.text = "";
        }
    }

 

    private void Update()
    {
        // Check if the "B" key is pressed.
        if (Input.GetKeyDown(KeyCode.B))
        {
            // Display the next animal fact or the first one if none is displayed.
            DisplayNextAnimalFact();
        }
    }

 

    private void DisplayNextAnimalFact()
    {
        if (animalFacts.Count == 0)
        {
            animalFactsText.text = "No animal facts available.";
            return;
        }

 

        // Increment the current fact index.
        currentFactIndex = (currentFactIndex + 1) % animalFacts.Count;

 

        // Display the current fact.
        animalFactsText.text = animalFacts[currentFactIndex];
    }
}
