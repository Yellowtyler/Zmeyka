using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastShotEnemyScript : MonoBehaviour
{
    public int timeattack;
    public int timeattack1;
    private int timeattacktem;
    private int timeattack1tem;
    private Transform player;
    private Vector2 target;
    public float speed;
    public float time;
    public float time1;
    public GameObject shot;
    public GameObject coll;
    public Animator anim;
    private bool change;
    private int l;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(enemybeh());
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);
        timeattacktem= timeattack ;
         timeattack1tem = timeattack1;
        change = false;
        l = 0;
       
    }

    // Update is called once per frame
    void Update()
    {
        target = new Vector2(player.position.x, player.position.y);
        if(change)
        {
            l++;
        }
        if(l==100)
        {
            anim.SetInteger("ChangeAnim", 0);
            change = false;
        }
    }
    IEnumerator enemybeh()
    {
        while (true)
        {
            coll.SetActive(false);
            while (timeattack != 0)
            {
                yield return null;
                timeattack--;
                transform.position = Vector2.MoveTowards(transform.position, target, speed*Time.deltaTime);

            }
            coll.SetActive(true);
            while(timeattack==0&&timeattack1!=0)
            {
                yield return null;
                timeattack1--;
                yield return new WaitForSeconds(time);
                change = true;
                anim.SetInteger("ChangeAnim", 1);
                yield return new WaitForSeconds(time1);
                Instantiate(shot, transform.position, transform.rotation);
            }
            timeattack = timeattacktem;
            timeattack1 = timeattack1tem;
        }
    }
   
}