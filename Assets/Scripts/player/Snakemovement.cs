using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snakemovement : MonoBehaviour
{
	public GameObject cube;
    public float speed = 5.0f;
	
    // Use this for initialization
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {
        var mouspos = Input.mousePosition;
		Vector3 mp = new Vector3 (mouspos.x-Screen.width/2, mouspos.y-Screen.height/2, 0)*0.01f;
		mp = new Vector3(mp.x+transform.position.x,mp.y+transform.position.y,mp.z);
    
		cube.transform.position= new Vector3(mp.x+transform.position.x,mp.y+transform.position.y,mp.z);
		gameObject.transform.LookAt(mp);
        
		cube.transform.position= mp;
        
        transform.Translate(0,0,0.01f*speed);
		//rb.AddForce(transform.forward * speed);
    }
}
