using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public GameObject CurrentCheckpoint;
    public Transform enemy;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void RespawnPlayer()
    {
        FindObjectOfType<player_controler>().transform.position = CurrentCheckpoint.transform.position;
    }
    public void RespawnEnemy()
    {
        Instantiate(enemy, transform.position, transform.rotation);
    }
}
