using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pocket : MonoBehaviour {

    public GameObject gamecom;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "keep")
        {
            Debug.Log("pocketed " + other.gameObject.name + "NOOOOOO");
        }
        else
        {
            if (other.Equals(8))
            {
               // Debug.Log("destroyed " + other);
               // Application.Quit();

                Scene scene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(scene.name);
            }
            else
            {
                Destroy(other.gameObject);
                Debug.Log("destroyed " + other);
            }
           
        }
    }
}
