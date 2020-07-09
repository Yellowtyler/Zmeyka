using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotMoveToPosScript : MonoBehaviour {
    public Transform pos;
    public float speed;
    public float time;
    private Vector2 target;
	// Use this for initialization
	void Start () {
      target = new Vector2(pos.position.x, pos.position.y);
    }
	
	// Update is called once per frame
	void Update () {
       
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        DestroyObject(gameObject, time);
        if(Vector2.Distance(transform.position,target)==0)
        {
            DestroyObject(gameObject);
        }
	}
}
