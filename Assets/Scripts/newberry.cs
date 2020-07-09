using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newberry : MonoBehaviour {
   public GameObject oldberry;
    public GameObject berrynew;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       
		if(oldberry== null)
        {
            Debug.Log("sdda");
            berrynew.SetActive(true);
        }
	}
}
