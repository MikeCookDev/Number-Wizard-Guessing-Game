using Debug = UnityEngine.Debug;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Microsoft.Win32.SafeHandles;

public class NumberWizard : MonoBehaviour
{

    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start() 
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        
        
        Debug.Log("I am The Number Wizard! Care to challenge me in a guessing game?!");
        Debug.Log("Please Pick A Number ");
        Debug.Log("The Highest Number you can choose is: " + max);
        Debug.Log("The Lowest Number you can choose is: " + min);
        Debug.Log("Tell me if your number is higher or lower than: " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()  
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I am unbeatable!!!");
            StartGame();
        }
    }
    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than..." + guess);
    }

}
