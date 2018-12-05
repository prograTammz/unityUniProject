using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controler : MonoBehaviour {
	public float moveSpeed;
	public float jumpHeight ;
	public bool isFacingRight;
	public KeyCode spacebar;
	public KeyCode L;
	public KeyCode R;
    public KeyCode F;
    public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool grounded;
    public float x,y,z;
    private Animator idle, run, dash;
    public Animator AniController;
    private bool hit;
    public AudioClip hitSound;
    public AudioClip walkSound;
    public int totalCoin;

    // Use this for initialization
    void Start () {
		x=transform.localScale.x;
		y=transform.localScale.y;
		z=transform.localScale.z;
		isFacingRight=true;
        idle = AniController;
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(spacebar)&& grounded){
			jump();
		}
        idle.SetBool("Grounded?", grounded);
        if (Input.GetKey(L)){
			GetComponent<Rigidbody2D>().velocity=new Vector2(-moveSpeed,GetComponent<Rigidbody2D>().velocity.y);
			if (isFacingRight){
				flip();
				isFacingRight=false;
			}
            AudioManager.instance.playSingle(walkSound);
		}
		if (Input.GetKey(R)){
			GetComponent<Rigidbody2D>().velocity=new Vector2(moveSpeed,GetComponent<Rigidbody2D>().velocity.y);
			if (!isFacingRight){
				flip();
				isFacingRight=true;
			}
            AudioManager.instance.playSingle(walkSound);
        }
        if (Input.GetKey(F))
        {
            idle.SetTrigger("hit");
            AudioManager.instance.playSingle(hitSound);
        };
        idle.SetFloat("speed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));
    }
	void jump(){
		GetComponent<Rigidbody2D>().velocity=new Vector2(GetComponent<Rigidbody2D>().velocity.x,jumpHeight);
	}
	void FixedUpdate(){
		grounded=Physics2D.OverlapCircle(groundCheck.position,groundCheckRadius,whatIsGround);
	}
	
   void flip(){
	   if (GetComponent<Rigidbody2D>().velocity.x>0){
		   transform.localScale=new Vector3(x,y,z);
	   }
	  else if (GetComponent<Rigidbody2D>().velocity.x<0){
		    transform.localScale=new Vector3(-x,y,z);
	   }
   }


}
