using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour {
    // This here goes to the game 
	public void playGame()
    {
        //play level1
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    //this would quit out of the game 
    public void Quit()
    {
        Application.Quit();
    }

    //
    public void main() {
        // load main menu
        SceneManager.LoadScene("Main");
    }

    public void level2() {
        // load level 2
        SceneManager.LoadScene("Level2");
    }
}
