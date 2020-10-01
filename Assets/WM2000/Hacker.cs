using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

    // Variables
    string input;
    string scrn;
    string password;
    int level;


	// Use this for initialization
	void Start () {
        Terminal.WriteLine("choose the difficulty of the Game");
        StartGame();
	}

    // First Function
    void StartGame () {

        MainMenu();

    }

    void MainMenu () {
        scrn = "menu";

        Terminal.WriteLine("1 for easy");
        Terminal.WriteLine("2 for medium");
        Terminal.WriteLine("3 for hard");
    }
	
    void OnUserInput (string input) {

        if (input == "menu") {
            MainMenu();
        }
        else if (scrn == "password") {
            CheckPass(input);
        }
        else if (scrn == "menu") {
            HandleMenu(input);
        }
    }

    void HandleMenu (string input) {
        bool validVal = (input == "1" || input == "2" || input == "3");
        if (validVal) {
            scrn = "password";
            level = int.Parse(input);
            PlayGame();
        }
        else
        {
            Terminal.WriteLine("wrong Level Input try again");
        }
    }
    
    void PlayGame () {
        Terminal.ClearScreen();
        Terminal.WriteLine("you have chosen level: " + level);

        switch (level) {
            case 1:
                password = "dog";
                break;
            case 2:
                password = "apple";
                break;
            case 3:
                password = "impossible";
                break;
        }
    }

    void CheckPass (string input) {
        if (input == password) {
            Terminal.WriteLine("YOU WON");
        }
        else {
            Terminal.WriteLine("TRY AGAIN");
        }
    }

	// Update is called once per frame
	void Update () {
		
	}
}
