using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomenemyspawn : MonoBehaviour {
    public GameObject enemy1;
    public GameObject enemy2;
    private int whatspawn;
    public float time;
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
            yield return new WaitForSeconds(time);
            whatspawn = Random.Range(1, 3);
            switch(whatspawn)
            {
                case 1: Instantiate(enemy1, transform.position, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(enemy2, transform.position, Quaternion.identity);
                    break;
                default: break;
                  
            }
        }
    }
}
