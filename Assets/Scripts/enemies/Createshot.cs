using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Createshot : MonoBehaviour {
    public float time;
    public GameObject shot;
    public bool shotting;
	// Use this for initialization
	void Start () {
        StartCoroutine(shotspawn());
       
    }

    // Update is called once per frame
   
    void Update () {
		
	}
   
    IEnumerator shotspawn()
    {
        while(shotting==true)
        {
            yield return new WaitForSeconds(time);
           Instantiate(shot, transform.position, transform.rotation);
        }
    }
}
