using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turn_controller : MonoBehaviour
{ 
    public float thrust;
    public Vector3 p = new Vector3();
    public Vector2 green;
    public Rigidbody2D rb;
    public float multiplier;
    //  float storedpos = p;
    public GameObject ball;
    public GameObject cue;
    public bool HasClicked = false;
    public int ballsunk;
    public int lastballsunk;
    // Angular speed in radians per sec.
    public float speed;
    private int turn;
    Vector3 storedpos;
    private float length;
    private float length2;
    //private float newX = 0;
    private Vector3 localPos;

    // 
    void Start()
    {
        storedpos = p;
        cue.SetActive(true);

    }

    // Convert the 2D position of the mouse into a
    // 3D position.  Display these on the game window.
    void OnGUI()
    {

        Camera c = Camera.main;
        Event e = Event.current;
        Vector2 mousePos = new Vector2();
        // Note that the y position from Event is inverted.
        mousePos.x = e.mousePosition.x;
        mousePos.y = c.pixelHeight - e.mousePosition.y;
        p = c.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, c.nearClipPlane));

    }

    void Update()
    {
        //if ball has stopped and the cue is inactive(not first turn)
        if (rb.velocity.magnitude <= 0.1f && cue.activeSelf == false)
        { 
            cue.SetActive(true);
        }

        if (HasClicked != true)///double check
        {
            Vector3 dir = p - rb.transform.position;
            // The step size is equal to speed times frame time.
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            ball.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        }
        else
        {
            length = Vector2.Dot((p - rb.transform.position).normalized, p - storedpos);
            localPos = cue.transform.localPosition;
            localPos.x = -8.53f - Mathf.Abs(length); ;
            cue.transform.localPosition = localPos;


        }
        if (Input.GetMouseButtonDown(0))
        {
            if (rb.IsSleeping())
            {
                storedpos = p;
                HasClicked = true;
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            if (HasClicked)
            {
                length2 = Mathf.Abs(Vector2.Dot((p - rb.transform.position).normalized, p - storedpos));
                rb.velocity = (storedpos - rb.transform.position).normalized * (length * multiplier);
            
                localPos = cue.transform.localPosition;
                localPos.x = -8.53f;
                cue.transform.localPosition = localPos;

                cue.SetActive(false);
                HasClicked = false;
            }
        }
    }

}
