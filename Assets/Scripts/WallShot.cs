using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallShot : MonoBehaviour {
    public GameObject shot;
    public Transform pos;
    public float time;
    public float time1;
    private ShotMoveToPosScript s;
    public Animator change;
	// Use this for initialization
	void Start () {
        StartCoroutine(spawn());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private IEnumerator spawn()
    {
        while(true)
        {
            yield return new WaitForSeconds(time1);
            change.SetInteger("Change", 1);
            
            yield return new WaitForSeconds(time);
            change.SetInteger("Change", 0);
            GameObject clone = Instantiate(shot, transform.position, transform.rotation);
            s = clone.GetComponent<ShotMoveToPosScript>();
            s.pos = pos;
        }
    }
    }

