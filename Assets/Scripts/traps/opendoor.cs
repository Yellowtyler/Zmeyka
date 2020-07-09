using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opendoor : MonoBehaviour {
    public GameObject lastberry;
    public GameObject lastberry1;
    public float speedx;
    public float speedy;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(lastberry== null&&lastberry1 == null)
        {
            Vector2 move = new Vector2(speedx, speedy);
            transform.Translate(move);
        }
	}
}
