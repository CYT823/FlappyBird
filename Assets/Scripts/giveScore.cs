using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class giveScore : MonoBehaviour {
    Text myText;
    int round;

    // Use this for initialization
    void Start () {
        myText = GetComponent<UnityEngine.UI.Text>();
    }
	
	// Update is called once per frame
	void Update () {
        round = Bird.getRound();
        int value = ((int)GameObject.Find("bird_0").transform.position.x - 24) / 4;
        setCountText(round * 12 + value);
    }

    //set count
    void setCountText(int value)
    {
        //Debug.Log("#Round:"+round);
        string score = "Score: " + value.ToString();
        myText.text = score;
    }
}
