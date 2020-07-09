using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineEnemyScrpit : MonoBehaviour {
    public Transform[] pos;
    public float speed;
    public GameObject mine;
    private int i;
    public float time;
	// Use this for initialization
	void Start () {
        StartCoroutine(spawn());
        i = Random.Range(0, pos.Length);
    }

    // Update is called once per frame
    void Update() {
        if (Vector2.Distance(transform.position, pos[i].position)==0)
        {
            i = Random.Range(0, pos.Length);
        }
        transform.position = Vector2.MoveTowards(transform.position, pos[i].position, speed * Time.deltaTime);
       
	}
    IEnumerator spawn()
    {
        while(true)
        {
            yield return new WaitForSeconds(time);
            Instantiate(mine, transform.position, transform.rotation);
        }
    }
}
