using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_follower : enemyController {

private player_controler player;
public float speedtowardsplayer;
	// Use this for initialization
	void Start () {
		player=FindObjectOfType<player_controler>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void update(){
		transform.position=Vector3.MoveTowards(transform.position,player.transform.position,speedtowardsplayer*Time.deltaTime);
	}
}
