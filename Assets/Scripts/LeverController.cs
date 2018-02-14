using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class LeverController : MonoBehaviour {

    VRTK_SpringLever rotator;

    public static LeverController instance;

    public bool start;

	// Use this for initialization
	void Start () {
        if (instance == null) {
            instance = this;
        } if (instance != this) {
            Destroy(gameObject);
        }

        start = false;
        rotator = GetComponentInChildren<VRTK_SpringLever>();
	}
	
	// Update is called once per frame
	void Update () {
        if (rotator.GetValue() > 40.0f) { //start the belt movement after the lever is pulled a certain amount
            start = true;
        }
	}
}
