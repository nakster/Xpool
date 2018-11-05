using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {
    //The ball script
    // for github
    public GameObject gamecom;
    public bool hascollided;
    void OnCollisionEnter2D(Collision2D coll)
    {
        if ((coll.gameObject.tag == "strip" || coll.gameObject.tag == "solid") && !hascollided)
        {
            Debug.Log(coll.gameObject.name);
            hascollided = true;
        }
    }
}
