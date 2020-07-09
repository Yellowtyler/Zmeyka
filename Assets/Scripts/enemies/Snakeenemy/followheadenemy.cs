using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followheadenemy : MonoBehaviour {
    public GameObject goLeader;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 v3FromLeader = transform.position - goLeader.transform.position;
        v3FromLeader = v3FromLeader.normalized * transform.localScale.y;
        transform.position = v3FromLeader + goLeader.transform.position;
        transform.up = v3FromLeader;
    }
}
