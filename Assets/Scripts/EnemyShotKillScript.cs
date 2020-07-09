using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShotKillScript : MonoBehaviour {
 
    public float time1;
    public float time;
    public GameObject kill;
   public Animator change;
	// Use this for initialization
	void Start () {
        StartCoroutine(Deathmoment());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
   
    IEnumerator Deathmoment()
    {
        while(true)
        {
            yield return new WaitForSeconds(time);
            change.SetInteger("Change", 1);
            kill.SetActive(true);
            yield return new WaitForSeconds(time1);
            change.SetInteger("Change", 0);
            kill.SetActive(false);
        }
    }
}
