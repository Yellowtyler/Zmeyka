using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShotAlongScript : MonoBehaviour {
    public Transform starpos;
    public Transform endpos;
    public bool spotted;
    public LayerMask wall;
    public GameObject shot;
    public float time;
    public float speed;
    // Use this for initialization
    void Start () {
        StartCoroutine(spawnshot());
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 move = new Vector2(0, speed*Time.deltaTime);
        transform.Translate(move);
        spotted = Physics2D.Linecast(starpos.position, endpos.position, wall);
        if(spotted)
        {
            transform.Rotate(0, 0, 270);
        }
	}
    IEnumerator spawnshot()
    {
        while(true)
        {
            yield return new WaitForSeconds(time);
            Instantiate(shot, transform.position, transform.rotation);
        }
    }
}
