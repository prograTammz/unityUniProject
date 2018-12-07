using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour {

    public int damage = 6;
    // Use this for initialization
    void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.tag == "Player")
        {
            FindObjectOfType<PlayerStats>().takeDamage(damage);
            FindObjectOfType<LevelManager>().RespawnPlayer();
        }
<<<<<<< HEAD
=======
            
            
>>>>>>> 6e33dc7f6aab3203e6962b04f162470ed1c878f8
    }
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
