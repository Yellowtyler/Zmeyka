using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class straightshot : MonoBehaviour {
    public float speedx;
    public float speedy;
    public Bossbomberscript Boss;
    public float time;
    private Vector2 move;
    // Use this for initialization
    void Start () {
        Boss = GameObject.Find("BossBomber").GetComponent<Bossbomberscript>();
    
    }
	
	// Update is called once per frame
	void Update () {
        move = new Vector2(speedx, speedy);
        transform.Translate(move * Time.deltaTime);
        DestroyObject(gameObject, time);
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Wall" || collision.tag == "Player")
        {
            DestroyObject(gameObject, 0.1f);
        }
    }
}
