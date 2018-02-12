using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Belt : MonoBehaviour {

    public float force;
    float start;

	// Use this for initialization
	void Start () {
        start = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        /* increase the speed over time
        float current = Time.time;

        if (current - start > 5.0) {
            force += 2;
            start = current;
        }*/

        transform.GetComponent<Rigidbody>().velocity = force * transform.right;
        
	}
}
