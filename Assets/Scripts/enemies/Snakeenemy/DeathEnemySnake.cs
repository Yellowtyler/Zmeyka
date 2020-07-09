using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathEnemySnake : MonoBehaviour {
    
    public int l;
    // Use this for initialization
    void Start () {
        l = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player"||collision.tag=="PlayerShot")
        {

            gameObject.SetActive(false);
            
        }
    }
}
