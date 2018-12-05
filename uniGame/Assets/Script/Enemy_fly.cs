using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_fly : enemyController {
public float HorizzontalSpeed;
public float VerticalSpeed;
public float amplitude;

private Vector3 temp_position;
public float moveSpeed;

private player_controler player;
	// Use this for initialization
	void Start () {
		temp_position=transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate(){
		temp_position.x +=HorizzontalSpeed;
		temp_position.y = Mathf.Sin(Time.realtimeSinceStartup*VerticalSpeed*amplitude);
        transform.position=temp_position;
	}
}
