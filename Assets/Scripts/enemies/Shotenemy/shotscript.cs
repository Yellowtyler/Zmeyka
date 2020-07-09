using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotscript : MonoBehaviour {
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
        
        transform.position=Vector2.MoveTowards(transform.position, target, speed*Time.deltaTime);
        if(Vector2.Distance(transform.position,target)==0)
        {
            Destroy(this.gameObject);
        }
        Destroy(this.gameObject, time);
	}
   
}
