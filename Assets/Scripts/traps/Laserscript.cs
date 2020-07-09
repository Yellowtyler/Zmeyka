using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laserscript : MonoBehaviour {
    public GameObject laser;
    public float time;
	// Use this for initialization
	void Start () {
        StartCoroutine(turnlaser());
      
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator turnlaser()
    {
        while(true)
        {
            yield return new WaitForSeconds(time);
            if(laser.activeSelf==true)
            {
                laser.SetActive(false);
               
            }
            else laser.SetActive(true);
        }
    }
}
