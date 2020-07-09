using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootScript : MonoBehaviour {
    public GameObject shot;
    public int ammo;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)&&ammo!=0)
        {
            ammo--;
            Instantiate(shot, transform.position, transform.rotation);
        }
	}
}
