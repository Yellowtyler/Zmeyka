using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerachangepos : MonoBehaviour {
    public GameObject wall;
    public Camera cam;
    public Transform newpos;
    public bool hit;
    public float speed;
    public GameObject otherexit;
    public GameObject otherexitwall;
    // Use this for initialization
    void Start () {
        hit = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(hit)
        {
            cam.transform.position = Vector3.MoveTowards(cam.transform.position, newpos.position, speed*Time.deltaTime);
           
            otherexit.SetActive(false);
            otherexitwall.SetActive(false);
        }
        if(hit==true&&cam.transform.position==newpos.position)
        {
            hit = false;
          
            otherexit.SetActive(true);
            otherexitwall.SetActive(true);
        }
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            hit = true;
               
            
        }
    }
    
}
