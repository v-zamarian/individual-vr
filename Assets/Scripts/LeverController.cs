﻿// Victor Zamarian
// 2/20/18

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class LeverController : MonoBehaviour {
    VRTK_SpringLever rotator;

    public bool start;
    public static LeverController instance;

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
        //start the belt movement after the lever is pulled a certain amount
        if (rotator.GetValue() > 20.0f) {
            start = true;
        }
	}
}
