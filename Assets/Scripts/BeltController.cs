using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltController : MonoBehaviour {

    public float speed; //public for testing

    float start;

    // Use this for initialization
    void Start () {
        start = Time.time;
        //speed = 0.0f;
    }

    // Update is called once per frame
    void Update () {
        //increase the speed over time
        /*float current = Time.time;

        if (current - start > 5.0) {
            speed += 1;
            start = current;
        }*/
    }
}
