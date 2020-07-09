using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeRoomScipt : MonoBehaviour {
    public GameObject[] enemies;
    public  int time;
    private int count;
    private int activate;
	// Use this for initialization
	void Start () {
        count = 0;
        activate = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (activate != 0)
        {
            
                time--;
            
            if (time == 0 && CheckDeath() != 0)
            {
                Application.LoadLevel(Application.loadedLevel);
            }
           else if (time>0&& CheckDeath() == 0)
            {
                DestroyObject(gameObject);
            }
            count = 0;
        }
	}
    int CheckDeath()
    {
        for(int i=0;i<enemies.Length;i++)
        {
            if(enemies[i]!=null)
            {
                count++;
            }
        }
        return count;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            activate++;
        }
    }
}
