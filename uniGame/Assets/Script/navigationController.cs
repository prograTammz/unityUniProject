﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class navigationController : MonoBehaviour {
    public void goLevel(int level)
    {
        Application.LoadLevel(level);
    }

    public void goToGameScene()
    {
        Application.LoadLevel(1);
    }

    public void goToGameOverScene()
    {
        Application.LoadLevel(6);
    }

    public void goToVictoryScene()
    {
        Application.LoadLevel(5);
    }

    public void Quit()
    {
        Application.Quit();
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}