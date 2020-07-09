using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemysnakemove : MonoBehaviour {
    public float speed = 1f; 
    private Transform player;
    public GameObject[] Snake;
    private GameObject curBodyPart;
    private GameObject PrevBodyPart;
    public float movespeed;

    // Use this for initialization
    void Start () {
       
        player = GameObject.FindGameObjectWithTag("Player").transform;
     
        
	}
	
	// Update is called once per frame
	void Update () {

        Move();
        DestroyParts();
    Vector3 move1 = new Vector3(0, 0,-90);
       
        
    }
   
    void Move()
    {
        /*Vector3 v3FromLeader1 = Snake[0].transform.position - player.position;
        v3FromLeader1 = v3FromLeader1.normalized * Snake[0].transform.localScale.y;
        Snake[0].transform.position = v3FromLeader1 + player.position;
        Snake[0].transform.up = v3FromLeader1;*/
        Snake[0].transform.position = Vector2.MoveTowards(Snake[0].transform.position, player.position, speed*Time.deltaTime);
        //Snake[0].transform.LookAt(player);
        //Snake[0].transform.position = Vector2.Lerp(Snake[0].transform.position, player.position, movespeed*Time.deltaTime);
        /*Vector3 dif =player.position - Snake[0].transform.position;
        dif.Normalize();
        float rotz = Mathf.Atan2(dif.x, dif.y) * Mathf.Rad2Deg;*/

        
        Vector2 direction = new Vector2(player.position.x -Snake[0].transform.position.x, player.position.y - Snake[0].transform.position.y);
       Snake[0].transform.up = direction;
        for (int i=1;i<Snake.Length;i++)
        {
            curBodyPart = Snake[i];
            PrevBodyPart = Snake[i - 1];
            Vector3 v3FromLeader = curBodyPart.transform.position - PrevBodyPart.transform.position;
            v3FromLeader = v3FromLeader.normalized * curBodyPart.transform.localScale.y;
            curBodyPart.transform.position = v3FromLeader + PrevBodyPart.transform.position;
            curBodyPart.transform.up = v3FromLeader;

            Vector2 direction1 = new Vector2(PrevBodyPart.transform.position.x - curBodyPart.transform.position.x, PrevBodyPart.transform.position.y - curBodyPart.transform.position.y);
            curBodyPart.transform.up = direction1;
            //curBodyPart.transform.localEulerAngles = new Vector3(0, 0, curBodyPart.transform.rotation.z);
        }
    }
   void DestroyParts()
    {
      
                for (int i = 1; i < Snake.Length; i++)
                {
                       if(Snake[i].activeSelf==false)
            {
                for (int j = 0; j < Snake.Length; j++)
                    Snake[j].SetActive(false);//DestroyObject(Snake[j]);
            }
                    
                }           
    }
}
