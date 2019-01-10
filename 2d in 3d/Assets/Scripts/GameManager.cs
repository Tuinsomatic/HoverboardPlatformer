using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public void StartGame()
    {
        SceneManager.LoadScene("Hoverboard Platformer"); //Starts a new game
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Main Menu"); //Ends the current game, and goes back to the title screen
    }
}
