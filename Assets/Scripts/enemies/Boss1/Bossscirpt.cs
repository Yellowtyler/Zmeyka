using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Bossscirpt : MonoBehaviour
{

    private Transform player;
    public float speed;
    public float time;
    public float deadtime;
    public int timeshhot;
    int temp;
    public int hp;
    public Transform[] points;
    public int i;
    public GameObject[] shot;
    public Transform[] spawnshot;
    bool t;
    public int stablehp;
    public bool check;
    public GameObject destroyzone;
    public Animator change;
    public GameObject bar;
    private bool turnon;
    // Use this for initialization
    void Start()
    {
        
        StartCoroutine(boss());
        bar.SetActive(true);
        destroyzone.SetActive(false);
        
        stablehp = hp;
        turnon = true;
        temp = timeshhot;
        player = GameObject.FindGameObjectWithTag("Player").transform;
        t = transform.position == points[0].position || transform.position == points[1].position||transform.position == points[2].position;
    }

    // Update is called once per frame
    void Update()
    {
        if(hp==0)
        {
            
            if(turnon==true)
            {
                change.SetInteger("change", 2);
                turnon = false;
            }
            deadtime -= deadtime * Time.deltaTime;
            if (deadtime < 1)
            {
                bar.SetActive(false);
                DestroyObject(this.gameObject);
            }
        }
    }
    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player"&& (Vector2.Distance(transform.position, points[0].position) == 0 || Vector2.Distance(transform.position, points[1].position) == 0 || Vector2.Distance(transform.position, points[2].position) == 0))
        {
           
            hp--;
            
        }
    }*/
    IEnumerator boss()
    {
        while (true)
        {
            while (timeshhot != 0)
            {

                yield return null;
                timeshhot--;
                transform.position = Vector2.MoveTowards(transform.position, player.position, speed);


            }
           
            i = Random.Range(0, 3);
            while (timeshhot == 0 && Vector2.Distance(transform.position,points[i].position)!=0)
            {
                yield return null;
                transform.position = Vector2.MoveTowards(transform.position, points[i].position, speed);

            }
            check = true;
            destroyzone.SetActive(true);
            change.SetInteger("change",1);
                
      
            while (Vector2.Distance(transform.position, points[i].position) == 0 && timeshhot == 0 && hp == stablehp)
            {

                yield return new WaitForSeconds(time);
                check = true;
               Transform shorpos=(Instantiate(shot[0], spawnshot[0].position, transform.rotation) as GameObject).transform;
                shorpos.SetParent(spawnshot[0]);
                Transform shorpos2 = (Instantiate(shot[1], spawnshot[2].position, transform.rotation) as GameObject).transform;
                shorpos2.SetParent(spawnshot[2]);
                Transform shorpos3 = (Instantiate(shot[2], spawnshot[3].position, transform.rotation) as GameObject).transform;
                shorpos3.SetParent(spawnshot[3]);
                Transform shorpos4 = (Instantiate(shot[4], spawnshot[4].position, transform.rotation) as GameObject).transform;
                shorpos4.SetParent(spawnshot[4]);
                Transform shorpos5 = (Instantiate(shot[4], spawnshot[5].position, transform.rotation) as GameObject).transform;
                shorpos5.SetParent(spawnshot[5]);
                Transform shorpos6 = (Instantiate(shot[3], spawnshot[6].position, transform.rotation) as GameObject).transform;
                shorpos6.SetParent(spawnshot[6]);
                Transform shorpos7 = (Instantiate(shot[3], spawnshot[7].position, transform.rotation) as GameObject).transform;
                shorpos7.SetParent(spawnshot[7]);
                Transform shorpos1 = (Instantiate(shot[0], spawnshot[1].position, transform.rotation) as GameObject).transform;        
                shorpos1.SetParent(spawnshot[1]);

            }
            var list = new List<int>();
            GameObject temp4;
            /* for(int i=0;i<shot.Length;i++)
              {
                  int y = Random.Range(0, shot.Length);
                 if(i==0)
                  {
                      temp4 = shot[y];
                      shot[y] = shot[i];
                      shot[i] = shot[y];
                  }
                  if (i != 0)
                  { for (int j = 0; j < list.Count; j++)
                      {
                          if (list[j] != y)
                          {
                              temp4 = shot[y];
                              shot[y] = shot[i];
                              shot[i] = shot[y];
                          }
                  } }
                  list.Add(y);
              }*/
          
            for(int i=0;i<shot.Length;i++)
            {
                list.Add(i);
            }
            int j = 0;
            
            while (j!=shot.Length)
            {
                int y = Random.Range(0, shot.Length);
                for (int l = 0; l < list.Count; l++)
                {
                    if (y == list[l])
                    {
                        list.Remove(list[l]);
                        shot[j] = shot[y];
                        j++;
                      
                        
                    }

                }

            }
                change.SetInteger("change", 0);
            destroyzone.SetActive(false);
            stablehp = hp;
            timeshhot = temp;
        }
    }
}
