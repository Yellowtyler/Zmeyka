using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hpsripty : MonoBehaviour {
    public int hp;
   private int statichp;
    private GameObject player;
   private Addpart partdel;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        partdel = player.GetComponent<Addpart>();
	}
	
	// Update is called once per frame
	void Update () {
	if(hp<=0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

      
        if ( collision.tag == "Berry")
        {
            hp++;
            statichp = hp;

        }
        else if ( collision.tag == "SnakeEnemy" || collision.tag == "Bomb" || collision.tag == "Shot" || collision.tag == "StraightShot" || collision.tag == "AroundShooter" || collision.tag == "Slime" || collision.tag == "Bomb1")
        {
            hp--;
            partdel.DestroyPart();
        }

    }
}
