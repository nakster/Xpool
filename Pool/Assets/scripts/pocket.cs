using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pocket : MonoBehaviour {

    // https://unity3d.com/learn/tutorials/topics/physics/detecting-collisions-oncollisionenter
    public GameObject gamecom;
     private Vector3 localPos;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "keep")
        {
            Debug.Log("pocketed " + other.gameObject.name + "NOOOOOO");
            //put it to the orginal position
            // cant set the positionof the object directly
            // create a variable 
            localPos = other.gameObject.transform.localPosition;
            localPos.x = -4.15f;
            localPos.y = 0;
            localPos.z = 0;
            other.gameObject.transform.localPosition = localPos;

            //set it inactive and then active again
            other.gameObject.SetActive(false);
            other.gameObject.SetActive(true);
            
        }
        else
        {
            //check if black popped
            if (other.gameObject.name == "8")
            {
                // this is to go to the menu when user pops black 
                Debug.Log("also other " + other);
                SceneManager.LoadScene("Main");
                // i reset the score here
                score.scoreValue = 0;
            }
            else
            {
                //to destry other balls 
                Destroy(other.gameObject);
                Debug.Log("destroyed " + other);
                // keep adding to the score 
                score.scoreValue += 10;
            }
           
        }
    }
}
