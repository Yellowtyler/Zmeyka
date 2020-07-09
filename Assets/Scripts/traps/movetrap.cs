using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetrap : MonoBehaviour {
    
    bool colliding;
         public Transform starpos;
    public Transform endpos;
   public LayerMask block;
    Transform thistrans;
    public float speed;
    Rigidbody2D thisbody;
    // Use this for initialization
    void Start () {
        thistrans = GetComponent<Transform>();
        thisbody = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        Vector2 move = thisbody.velocity;
        move.y = thistrans.up.y * speed;
        thisbody.velocity = move;
        colliding = Physics2D.Linecast(starpos.position, endpos.position, block);
        if(colliding)
        {
            Vector3 currot = thistrans.eulerAngles;
            currot.x += 180;
            thistrans.eulerAngles = currot;
        }
	}
}
