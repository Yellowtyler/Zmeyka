using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastEnemyScript : MonoBehaviour {
    private Transform player;
    public float speed;
    public float dist;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").transform;

	}
	
	// Update is called once per frame
	void Update () {
        if (Vector2.Distance(transform.position, player.position) < dist)
        { transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime); }
	}
}
