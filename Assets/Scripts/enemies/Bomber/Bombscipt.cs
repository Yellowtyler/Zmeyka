using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombscipt : MonoBehaviour {
    private Transform player;
    public float speed;
    public float time;
    public float time1;
    private int l;
    public Animator change;
    // Use this for initialization
    void Start () {
        StartCoroutine(destroy());
        player = GameObject.FindGameObjectWithTag("Player").transform;
        l = 0;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position=Vector2.MoveTowards(transform.position, player.position, speed*Time.deltaTime);
       
          
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player"|| collision.tag == "PartSnake")
        {
            change.SetInteger("change", 1);
            DestroyObject(gameObject, 0.1f);
        }
        else if(collision.tag=="Bomb1")
        {
            l++;
            if(l==2)
            {
                // DestroyObject(collision.gameObject);
                collision.gameObject.SetActive(false);
            }
        }
    }
    IEnumerator destroy()
    {
        while(true)
        {
            yield return new WaitForSeconds(time);
            change.SetInteger("change", 1);
            DestroyObject(this.gameObject,time1);
           
        }
    }

}
