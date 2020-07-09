using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostEnemyScript : MonoBehaviour {
    public LayerMask ghost;
    private Transform startpos;
    private Transform endpos;
   public bool spotted;
    public float speed;
    private Transform player;
    private float temp;
    public Animator change;
    public GameObject weakness;
	// Use this for initialization
	void Start () {
        temp = speed;
       
        player = GameObject.FindGameObjectWithTag("Player").transform;
        startpos = GameObject.FindGameObjectWithTag("StartPosPlayer").transform;
        endpos = GameObject.FindGameObjectWithTag("EndPosPlayer").transform;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector2.MoveTowards(transform.position, player.position, speed*Time.deltaTime);
        spotted = Physics2D.Linecast(startpos.position, endpos.position, ghost);
        if(spotted)
        {
            change.SetInteger("Change", 1);
            weakness.SetActive(true);
            speed = 0;
        }
        else
        {
            change.SetInteger("Change", 0);
            weakness.SetActive(false);
            speed = temp;
        }
	}
}
