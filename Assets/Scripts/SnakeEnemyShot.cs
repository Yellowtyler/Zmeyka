using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeEnemyShot : MonoBehaviour {
    public GameObject shot;
    public float time;
    public Transform position;
	// Use this for initialization
	void Start () {
        StartCoroutine(spawn());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator spawn()
    {

        while(true)
        {
            GameObject clone= Instantiate(shot, transform.position, transform.rotation);
           ShotMoveToPosScript trend = clone.GetComponent<ShotMoveToPosScript>();
            trend.pos = position;
            trend.speed = trend.speed + 4f;
            yield return new WaitForSeconds(time);
        }
    }
}
