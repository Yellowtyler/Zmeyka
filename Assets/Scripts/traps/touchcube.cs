﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchcube : MonoBehaviour {
   
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player"|| collision.tag == "PartSnake")
        {

            Application.LoadLevel(Application.loadedLevel);
        }
        
    }
}
