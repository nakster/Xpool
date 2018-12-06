using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {
    //The ball script
    // for github
    // for collion detection
    private GameObject gamecom;
    public bool hascollided;

    //for music effect
    public AudioSource hit;

    private Transform player;


    //https://forum.unity.com/threads/oncollisionenter2d-not-working.219802/
    //https://answers.unity.com/questions/1239503/oncollisionenter2d-not-being-called-1.html
    void Start(){
        hit = GetComponent<AudioSource>();
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if ((coll.gameObject.tag == "strip" || coll.gameObject.tag == "solid") && !hascollided)
        {
            //play music when comes in contact
            hit.Play();
            Debug.Log(coll.gameObject.name);
            hascollided = true;
        }else{
             hascollided = false;
        }
    }
}
