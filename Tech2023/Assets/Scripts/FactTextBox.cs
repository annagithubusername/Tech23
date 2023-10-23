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
        animalFacts.Add("About 50% of the world's tropical forests have been cleared already");
        animalFacts.Add("By the year 2030, we might only have 10% of our forests left");
        animalFacts.Add("Rainforests cover only 6% of the world’s surface");
        animalFacts.Add("Rainforests are home to more than 50% of the plant and animal species on Earth");
        animalFacts.Add("Every minute forests the size of 20 football fields are cut down");
        animalFacts.Add("15% of all greenhouse gasses come from deforestation activities");
 

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
        // when player presses the b key.
        if (Input.GetKeyDown(KeyCode.B))
        {
            // the next animal fact or the first one if none is displayed.
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
