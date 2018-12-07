using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{

    public GameObject enm;

    // Use this for initialization
    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D X)
    {
        if (X.tag == "Enemy")
        {
            FindObjectOfType<WalkingEnemy>().takeDamage(6);
            
        }
    }
    

    // Update is called once per frame
    void Update()
    {

    }
}
