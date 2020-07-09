using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBehaveSnake : MonoBehaviour {
    int hp;
    public GameObject part1;
    public GameObject part2;
    public GameObject part3;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(part1.activeSelf== true&&part2.activeSelf == false && part3.activeSelf == false)
        {
            hp = 2;
        }
       else if (part2.activeSelf == true&& part1.activeSelf == true && part3.activeSelf == false)
        {
            hp = 3;
        }
     else   if (part2.activeSelf == true && part1.activeSelf == true && part3.activeSelf ==true )
        {
            hp = 4;
        }
        else hp = 1;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="SnakeEnemy")
        {
            hp--;
            if (hp == 1)
            {
                DestroyObject(part1);
            }
            else if (hp == 2)
            {
                DestroyObject(part2);
            }
            else if (hp == 3)
            {
                DestroyObject(part3);
            }
            else Application.LoadLevel("b");
        }
    }
}
