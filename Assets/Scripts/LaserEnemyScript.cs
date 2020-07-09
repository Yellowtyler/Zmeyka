using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserEnemyScript : MonoBehaviour {
    private GameObject Player;
    public GameObject laser;
    public Animator anim;
	// Use this for initialization
	void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
      
    }
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX;
        GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
        Vector3 target = transform.position - Player.transform.position;
        target = target.normalized * transform.localScale.y;
        transform.up = target;
        if (laser.activeSelf == true)
        {
            anim.SetInteger("Change", 1);
        }
        else
        {
            anim.SetInteger("Change", 0);
        }
    }
    protected void LateUpdate()
    {
        transform.localEulerAngles = new Vector3(0, 0, transform.localEulerAngles.z);
    }
   
}
