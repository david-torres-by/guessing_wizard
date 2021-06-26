using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Number_Wizard_Console : MonoBehaviour
{
    int max_guess = 100;
    int min_guess = 1;
    int guess = 50;
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Welcome to the number wizard game!");
        Debug.Log("Pick a number, partnaaa (dont' tell me what it is)");
        Debug.Log("Highest number is: " + max_guess);
        Debug.Log("Lowest number is: " + min_guess);
        Debug.Log("Tell me if your number is higher or number than what I'm thinking");
        
    }

    // Update is called once per frame
    void Update()
    {
        //Detect when the down arrow key is pressed up
        if (Input.GetKeyDown(KeyCode.UpArrow))
        //It's good practice to keep the actions of the if inside a curly bracket
        {
            Debug.Log("Up Arrow key was pressed.");
            min_guess = guess;
            Debug.Log(guess);
        }

        //Detect when the down arrow key is pressed down
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow key was pressed.");
            max_guess = guess;
            Debug.Log(guess);
        }

        //Detect when the Return key is pressed down
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter key was pressed.");
        }

    }
}

