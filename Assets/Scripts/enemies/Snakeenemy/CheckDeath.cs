using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDeath : MonoBehaviour {
    public GameObject head;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(head.activeSelf==false)
        {
            gameObject.SetActive(false);
        }
	}
}
