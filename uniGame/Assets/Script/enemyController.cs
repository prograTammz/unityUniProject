using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour {

    public bool isFacingRight = false;
    public float maxSpeed = 3f;
    public int damage = 6;
    //public AudioClip hit1;
    //public AudioClip hit2;
    public Animator idle, run, dash;
    public Animator AniController;

    public void flip()
    {
        isFacingRight = !isFacingRight;
        transform.localScale = new Vector3(-(transform.localScale.x), transform.localScale.y, transform.localScale.z);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<PlayerStats>().takeDamage(damage);
        }
    }

    // Use this for initialization
    void Start()
    {
        idle = AniController;
    }

    // Update is called once per frame
    void Update()
    {
        idle.SetFloat("speed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));
    }
}
