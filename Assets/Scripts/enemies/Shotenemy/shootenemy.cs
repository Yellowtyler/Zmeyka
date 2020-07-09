using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootenemy : MonoBehaviour {
    public GameObject shot;
        public Transform player;
    public float speedx;
    public float Delay;
  
	// Use this for initialization
	void Awake () {
        StartCoroutine(createshot());
      
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(player);
	}
    IEnumerator createshot()
    {
        while(true)
        {
            yield return new WaitForSeconds(Delay);
            GameObject clone = (GameObject)Instantiate(shot, transform.position, Quaternion.identity);
           
           
        }
    }
}
