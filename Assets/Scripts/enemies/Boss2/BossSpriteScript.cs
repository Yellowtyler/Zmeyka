using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpriteScript : MonoBehaviour {

    public float speed;
    private Transform boss;
    public Bossbomberscript b;
    // Use this for initialization
    void Start () {
        boss = GameObject.FindGameObjectWithTag("Boss").transform;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector2.MoveTowards(transform.position, boss.position, speed * Time.deltaTime);
        if(b.deadtime<1.4)
        {
            DestroyObject(gameObject);
        }
	}
}
