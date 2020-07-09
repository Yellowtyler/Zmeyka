using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour {
    public float speed;


    public float time;
    private Vector2 target;
    private Transform player;
    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector2.MoveTowards(transform.position, target, speed);
        if (Vector2.Distance(transform.position, target) == 0)
        {
            Destroy(this.gameObject);
        }
        Destroy(this.gameObject, time);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if( collision.tag == "SnakeEnemy" || collision.tag == "Bomb" || collision.tag == "Shot" || collision.tag == "StraightShot" || collision.tag == "AroundShooter" || collision.tag == "Slime" || collision.tag == "PartEnemySnake" || collision.tag == "Bomb1")
        {
            //DestroyObject(collision.gameObject);
            collision.gameObject.SetActive(false);
            DestroyObject(this.gameObject);
        }
    }
}
