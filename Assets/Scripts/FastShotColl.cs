using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastShotColl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag =="Player")
        {
            //DestroyObject(transform.parent.gameObject);
            transform.parent.gameObject.SetActive(false);
        }
    }
}
