﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_spawns : enemyController {

    // Use this for initialization
    private int Counter = 0;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other){
		if(other.tag=="Player" & Counter <=10 ){
FindObjectOfType<LevelManager>().RespawnEnemy();
            Counter++;
		}
	}
}
