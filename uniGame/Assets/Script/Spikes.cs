using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour {

    // Use this for initialization
    void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.name == "Player")
            FindObjectOfType<LevelManager>().RespawnPlayer();
    }
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
