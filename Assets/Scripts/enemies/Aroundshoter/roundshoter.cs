using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roundshoter : MonoBehaviour {
    public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 axis = new Vector3(0, 0, transform.position.z);
        transform.RotateAroundLocal(axis, speed*Time.deltaTime);
	}
}
