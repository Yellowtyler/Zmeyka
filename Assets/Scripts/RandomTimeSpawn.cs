using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTimeSpawn : MonoBehaviour {
   public GameObject[] enemies;
    public float time;
    public float destroytime;
 
    int i;
	// Use this for initialization
	void Start () {
        StartCoroutine(spawn());
        i = 0;
        
	}
	
	// Update is called once per frame
	void Update () {
        destroytime -= destroytime * Time.deltaTime;
        
        if(destroytime<=1)
        {
            DestroyObject(gameObject);
        }
	}
    IEnumerator spawn()
    {
        while(true)
        {
            i = Random.Range(0, enemies.Length);
            Instantiate(enemies[i], transform.position, transform.rotation);
            yield return new WaitForSeconds(time);


        }
    }
}
