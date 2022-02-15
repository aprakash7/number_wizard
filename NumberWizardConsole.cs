using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizardConsole : MonoBehaviour {
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
        Debug.Log(" This is just a test");
        Debug.Log("Pick a number and don't tell me!");
        Debug.Log("The highest number you can pick is:" + max);
        Debug.Log("The lowest number you can pick is:" + min);
        Debug.Log("Tell me if your number is higher or lower than" + guess);
        Debug.Log(" Push up = Higher, Push down = Lower, Hit Enter = correct");
        max = max + 1;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
           
            min = guess;
            guess = (max + min) / 2;
            NextGuess();
         }
        else if(Input.GetKeyUp(KeyCode.DownArrow))
        {
            max = guess;
            guess = (max + min) / 2;
            NextGuess();

        }
        else if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter key was pressed");
            StartGame();
        }
    }
    void NextGuess()
    {
        Debug.Log(guess);
        Debug.Log("Okay you guessed: " + guess + "! Is your guess higher than: " + guess);
    }
}
