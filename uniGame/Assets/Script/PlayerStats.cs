using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour {

    public int health = 6;
    public int lives = 3;
    private float flickerTime = 0f;
    private float flickerDuration = 0.1f;
    private SpriteRenderer spriteRenderer;
    public bool inImmune = false;
    private float immunityTime = 0f;
    public float immunityDuration = 1.5f;
    public int coinsCollected = 0;
    public AudioClip gameOverSound;
    public Text scoreUI;
    public Slider healthUI;
    public Animator Ani;
    public AudioClip Die;
    // Use this for initialization
    void Start () {
        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void spriteFlicker()
    {
        if (this.flickerTime < this.flickerDuration)
        {
            this.flickerTime = this.flickerDuration + Time.deltaTime;
        }
        else if (this.flickerTime >= this.flickerDuration)
        {
            //spriteRenderer.enabled = !(spriteRenderer.enabled);
            this.flickerTime = 0;
        }

    }

    void PlayHitReaction()
    {
        this.inImmune = true;
        this.immunityTime = 0;
    }

    public void takeDamage(int damage)
    {
        
        print(damage);
        print(lives);
       
        this.health = this.health - damage;
            if (this.health < 0) { this.health = 0;  }
            if (this.lives > 0 && this.health == 0)
            {
                
                this.health = 6;
                this.lives--;
                Ani.SetTrigger("Die");
            AudioManager.instance.playSingle(Die);
            FindObjectOfType<LevelManager>().RespawnPlayer();
        }
        else
        {
            Ani.SetTrigger("GetHurt");
        }
            if (this.lives == 0 && this.health == 0)
            {
                Debug.Log("Gameover");
            //AudioManager.instance.playSingle(gameOverSound);
            AudioManager.instance.playSingle(Die);
            AudioManager.instance.musicSource.Stop();
            Destroy(gameObject);
            (new navigationController()).goToGameOverScene();
        }
            Debug.Log("Player Health: " + this.health.ToString());
            Debug.Log("Player Lives: " + this.lives.ToString());
            PlayHitReaction();
    }
    void Update () {
       
        //scoreUI.text = "" + coinsCollected;
        //healthUI.value = health;
    }
    public void collectCoin(int coinValue)
    {
        this.coinsCollected = this.coinsCollected + coinValue;
        print(this.coinsCollected);
    }
}
