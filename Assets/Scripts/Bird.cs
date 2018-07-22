using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour {
    //Times of round
    public static int round;

    // Movement speed
    public int speed;

    // Flap force
    public float force;

    // Use this for initialization
    void Start()
    {
        round = 0;
        force = 300;
        speed = 2;
        // Fly towards the right
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        // Flap
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
            if(transform.position.x > 71)
            {
                transform.position = new Vector2(23.6f, transform.position.y);
                round++;
            }
        }else if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }else if (Input.GetKeyDown(KeyCode.P))
        {
            pause.PauseGame();
        }

        if (transform.position.y > 12) //fly over the max height
        {
            SceneManager.LoadScene("SampleScene");
        }
        
    }

    //Touch the ground will restart the game
    void OnCollisionEnter2D(Collision2D coll)
    {
        SceneManager.LoadScene("SampleScene");
    }
    
    //return the round times
    public static int getRound()
    {
        return round;
    }
}
