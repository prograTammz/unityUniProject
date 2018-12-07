using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{

    public GameObject enm;
    private int scene4Counter = 0;
    // Use this for initialization
    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D X)
    {
        if (X.tag == "Enemy")
        {
            FindObjectOfType<WalkingEnemy>().takeDamage(6);
            if (X.name == "knightScene4" || X.name == "knightScene4(Clone)")
            {
                scene4Counter++;
                if(scene4Counter == 10)
                {

                }
            }
            else if (X.name == "Hendrick - prefab")
            {
                (new navigationController()).goToVictoryScene();
            }
            
        }
    }
    

    // Update is called once per frame
    void Update()
    {

    }
}
