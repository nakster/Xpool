using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class PauseMenu : MonoBehaviour {
    public static bool GamePaused = false;
 
    public GameObject pauseMenuUI;
   
    // Update is called once per frame
    void Update () {
        //this is for when escape button is pressed 
        if(Input.GetKeyDown(KeyCode.Escape)) {
            if (GamePaused == true) {
                Resume();
            } else
            {
                Pause();
            }
        }
    }

    //resumes the game
    public void Resume() {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f; 
        GamePaused = false;
    }
 
    //pauses the game 
    public void Pause() {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f; 
        GamePaused = true;
    }
 
    //loadts the option menu
    public void LoadOptions() {
        SceneManager.LoadScene("Options");
    }

    //goes to the mian menu
    public void Quit() {
        Time.timeScale = 1f;
		Debug.Log("In quit");

        SceneManager.LoadScene("Main");
    }
}