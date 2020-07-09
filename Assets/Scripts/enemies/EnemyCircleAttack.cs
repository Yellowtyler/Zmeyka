using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCircleAttack : MonoBehaviour {
    private Transform player;
    public float dist;
    public float speed;
    private Vector2 target;
    private Vector2 lastpos;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        OnDrawGizmos();
	}
	
	// Update is called once per frame
	void Update () {
        target = new Vector2(player.position.x, player.position.y);
        lastpos = new Vector2(transform.position.x, transform.position.y);
        
		if(Vector2.Distance(transform.position,player.position)<=dist)
        {
            transform.position = Vector2.MoveTowards(transform.position, target, speed);
            
        }
        if(Vector2.Distance(transform.position,target)==0)
        {
            transform.position = Vector2.MoveTowards(transform.position, lastpos, speed);
        }
	}
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position,dist);
    }
}
