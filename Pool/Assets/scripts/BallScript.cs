using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {
    //The ball script
    // for github
    private GameObject gamecom;
    public bool hascollided;

    public AudioSource hit;

    private Transform player;


    void Start(){
        hit = GetComponent<AudioSource>();
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if ((coll.gameObject.tag == "strip" || coll.gameObject.tag == "solid") && !hascollided)
        {
            hit.Play();
            Debug.Log(coll.gameObject.name);
            hascollided = true;
        }else{
             hascollided = false;
        }
    }
}
