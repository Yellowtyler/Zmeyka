using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawn : MonoBehaviour {
  public  int openingdir;
    RoomTemplates temp;
    private int rand;
    private bool spawned=false;
	// Use this for initialization
	void Start () {
        temp = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        Invoke("Spawn",0.1f);
	}
	
	// Update is called once per frame
	void Spawn () {
        if (spawned == false)
        {
            if (openingdir == 1)
            {
                rand = Random.Range(0, temp.LeftRooms.Length);
                Instantiate(temp.LeftRooms[rand], transform.position, Quaternion.identity);
            }
            else if (openingdir == 2)
            {
                rand = Random.Range(0, temp.RightRooms.Length);
                Instantiate(temp.RightRooms[rand], transform.position, Quaternion.identity);

            }
            else if (openingdir == 3)
            {
                rand = Random.Range(0, temp.UpRooms.Length);
                Instantiate(temp.UpRooms[rand], transform.position, Quaternion.identity);

            }
            else if (openingdir == 4)
            {
                rand = Random.Range(0, temp.DownRooms.Length);
                Instantiate(temp.DownRooms[rand], transform.position, Quaternion.identity);

            }
            spawned = true;
        }
     
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag =="SpawnPoint"&&collision.GetComponent<RoomSpawn>().spawned==true)
        {
            Destroy(gameObject);
        }
    }
}
