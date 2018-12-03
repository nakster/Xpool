using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class PauseMenu : MonoBehaviour {
    public static bool GamePaused = false;
 
    public GameObject pauseMenuUI;
   
    // Update is called once per frame
    void Update () {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            if (GamePaused == true) {
                Resume();
            } else
            {
                Pause();
            }
        }
    }
 
    public void Resume() {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f; // unfreeze gameplay
        GamePaused = false;
    }
 
    public void Pause() {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f; // freeze gameplay
        GamePaused = true;
    }
 
    public void LoadOptions() {
        // Time.timeScale = 1f;
        SceneManager.LoadScene("Options");
    }
 
    public void Quit() {
        Time.timeScale = 1f;
		Debug.Log("In quit");
 
        // load main menu
        SceneManager.LoadScene("Main");
    }
}