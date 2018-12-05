using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_follower : enemyController {

	// Use this for initialization
	private player_controler player;
	public float speedtowardplayer;
	void Start () {
		player=FindObjectOfType<player_controler>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.position=Vector3.MoveTowards (transform.position,player.transform.position,speedtowardplayer*Time.deltaTime);
	}
}
