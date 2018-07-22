using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public Transform target;

    void Start()
    {
        // The Target
        target = GameObject.Find("bird_0").transform;
    }

    // Update is called once per frame
    void Update () {
        transform.position = new Vector3(target.position.x, transform.position.y, transform.position.z);
    }

    //Having perfectly smooth
    void LateUpdate()
    {
        transform.position = new Vector3(target.position.x, transform.position.y, transform.position.z);
    }
}
