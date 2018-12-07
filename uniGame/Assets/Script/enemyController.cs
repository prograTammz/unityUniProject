using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour {

    public bool isFacingRight = false;
    public float maxSpeed = 3f;
    public int damage = 6;
    public bool isDied=false;
    public int health = 0;
    public AudioClip Die;
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
    public void takeDamage(int damage)
    {
        this.health -= damage;
        Debug.Log(this.health);
        if(this.health  <= 0)
        {
           
            idle.SetTrigger("Die");
            Destroy(this.gameObject);
            AudioManager.instance.playSingle(Die);
            this.isDied = true;
        }
    }
}
