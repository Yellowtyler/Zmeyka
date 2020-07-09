using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bossbomberscript : MonoBehaviour {
    public int timeattack;
    public int timestay;
  public float deadtime;
    public GameObject bomb;
    public GameObject shot;
    public int hp;
    private int checkhp;
    public Transform starpos;
    public Transform endpos;
    public float speed;
    Vector2 move;
    public bool spotted;
    public LayerMask block;
    private int temp;
    private int temp1;
    public GameObject wall;
    public Animator change;
    public GameObject bar;
    private bool turnon;
    // Use this for initialization
    void Start () {
        
        StartCoroutine(Bossbehaviour());
        turnon = true;
        bar.SetActive(true);
        move = new Vector2(0, speed);
        checkhp = hp;
        temp = timeattack;
        temp1 = timestay;
        
    }
	
	// Update is called once per frame
	void Update () {
       
        transform.Translate(move * Time.deltaTime);
        if(timeattack==0)
        {
            move = new Vector2(0, 0);
        }
        else
        {
            move = new Vector2(0, speed);
        }
        if (hp==0)
        {
            deadtime -= deadtime * Time.deltaTime;
            if(turnon==true)
            {
                change.SetInteger("change", 2);
                turnon = false;
            }
            if (deadtime < 1)
            {
                bar.SetActive(false);
                DestroyObject(gameObject); }

        }
        if(timeattack==0)
        {
            
            wall.SetActive(false);
        }
         else
        {
            wall.SetActive(true);
        }

       
	}
    IEnumerator Bossbehaviour()
    {
       
        while (true)
        {
           
            while (timeattack != 0)
            {
                yield return null;
                
                timeattack--;
                spotted = Physics2D.Linecast(starpos.position, endpos.position, block);
                if (spotted)
                {
                    transform.Rotate(0, 0, 180);
                    
                }
               
              
            }
            change.SetInteger("Change", 1);
            while (timeattack==0&&hp==checkhp&&timestay != 0)
            {
               
                timestay--;
                yield return new WaitForSeconds(2);
                Instantiate(bomb, transform.position, transform.rotation);
                
            }
            change.SetInteger("Change", 0);
            timeattack = temp;
          
            timeattack = temp;
            timestay = temp1;
            checkhp = hp;

        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player"&&timeattack==0)
        {
            hp--;
            BossHealthBarScript.health -= 10f;
        }
    }
}
