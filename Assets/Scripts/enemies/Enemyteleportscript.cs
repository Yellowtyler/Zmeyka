using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyteleportscript : MonoBehaviour {
    public float time;
    private Vector2 target;
    private Transform player;
    public float starttime;
    private float timeshot;
    public float speed;
	// Use this for initialization
	void Start () {
       
        player = GameObject.FindGameObjectWithTag("Player").transform;
        StartCoroutine(teleport());
        
	}
	
	// Update is called once per frame
	void Update () {
        target = new Vector2(player.position.x, player.position.y);
       
    }
   IEnumerator teleport()
    {
        while(true)
        {
            yield return new WaitForSeconds(time);
            transform.position = Vector2.MoveTowards(transform.position, target, speed);
        }
    }

}
