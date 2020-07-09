using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Createstraightshot : MonoBehaviour {
    public GameObject shot;
    public float time;
    public float speed;
	// Use this for initialization
	void Start () {
      
        StartCoroutine(createshot());
        

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator createshot()
    {
        while(true)
        {
            yield return new WaitForSeconds(time);
            Instantiate(shot, transform.position,transform.rotation);
        }
    }
}
