using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenu : MonoBehaviour {

    //methods that are used in buttons created below
    //these methods are for loading another scenes
    public void startGame()
    {
        Application.LoadLevel("Level1");
    }

    public void Levels()
    {
        Application.LoadLevel("Levels");
    }

    public void Help()
    {
        Application.LoadLevel("Help");
    }

    //method that quits the game
    public void Quit()
    {
        Application.Quit();
    }
}
