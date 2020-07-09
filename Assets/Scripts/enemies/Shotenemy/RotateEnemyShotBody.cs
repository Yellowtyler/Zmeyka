using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateEnemyShotBody : MonoBehaviour {
    private Transform player;
    public float speed;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {

        transform.LookAt(player);
	}
   protected void LateUpdate()
    {
        transform.localEulerAngles = new Vector3(0, 0, transform.rotation.z);
    }
}
