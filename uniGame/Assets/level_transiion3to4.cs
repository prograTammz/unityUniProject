﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level_transiion3to4 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	 void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
         (new navigationController()).goLevel(3);
        }
    }
}
