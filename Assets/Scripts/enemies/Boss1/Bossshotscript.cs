using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bossshotscript : MonoBehaviour {
    public float speedx;
    public float speedy;
    public float time;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       Vector2 move = new Vector2(speedx, speedy);
        transform.Translate(move);
        DestroyObject(this.gameObject, time);
	}
}
