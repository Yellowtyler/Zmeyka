using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour {
    public float movespeed = 0.004f;
    
    
    private Vector3 target;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector2.Lerp(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition), movespeed);
        Vector3 dif = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        dif.Normalize();
        float rotz = Mathf.Atan2(dif.x, dif.y) * Mathf.Rad2Deg;

        Vector3 mouspos = Input.mousePosition;
        mouspos = Camera.main.ScreenToWorldPoint(mouspos);
        Vector2 direction = new Vector2(mouspos.x - transform.position.x, mouspos.y - transform.position.y);
        transform.up = direction;
    }
}
