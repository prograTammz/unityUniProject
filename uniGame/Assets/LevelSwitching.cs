﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSwitching : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D()
    {
        (new navigationController()).goLevel(2);
    }
}
