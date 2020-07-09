using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hppartscript : MonoBehaviour {
    private hpsripty hp;
    private Addpart destroy;
    private GameObject player;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        destroy = player.GetComponent<Addpart>();
        hp = player.GetComponent<hpsripty>(); 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.tag == "SnakeEnemy" || collision.tag == "Bomb" || collision.tag == "Shot" || collision.tag == "StraightShot" || collision.tag == "AroundShooter" || collision.tag == "Slime" || collision.tag == "Bomb1")
        {
            hp.hp--;
            destroy.DestroyPart();
        }
    }
}
