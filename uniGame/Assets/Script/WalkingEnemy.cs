using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingEnemy : enemyController {

    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Wall")
        {
            flip();
        }
        if (collision.tag == "Enemy")
        {
            flip();
        }
        if (collision.tag == "Player")
        {
            FindObjectOfType<PlayerStats>().takeDamage(damage);
            AniController.SetTrigger("Hit");
            flip();
        }
    }
    private void FixedUpdate()
    {
        if (!isDied)
        {
            if (this.isFacingRight == true)
            {
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(maxSpeed, this.GetComponent<Rigidbody2D>().velocity.y);
            }
            else
            {
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(-maxSpeed, this.GetComponent<Rigidbody2D>().velocity.y);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}

