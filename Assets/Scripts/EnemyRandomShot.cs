using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRandomShot : MonoBehaviour {
    private Transform player;
    public float speed;
    public Transform[] shotpos;
    public int[] i;
   public float time;
    public float time1;
    public GameObject shot;
    private float temp2;
    private float temp;
    private float temp1;
    private ShotMoveToPosScript pos;
   public Animator change;
    private bool onetime;
    // Use this for initialization
    void Start () {
       // StartCoroutine(spawn());
        player = GameObject.FindGameObjectWithTag("Player").transform;
        temp2 = time1;
        temp = time;
        temp1 = speed;
        onetime = true;
       
	}
	
	// Update is called once per frame
	void Update () {
        if (time > 1)
        {
            speed = temp1;
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            time -= time * Time.deltaTime; }
        else if (time < 1 && time1 > 1)
        {
            change.SetInteger("Change", 1);
            speed = 0;
            
            if (onetime == true)
            {
                for (int r = 0; r < i.Length; r++)
                {
                    i[r] = Random.Range(0, shotpos.Length);
                    Debug.Log("lol");
                    GameObject clone = Instantiate(shot, transform.position, transform.rotation);
                    pos = clone.GetComponent<ShotMoveToPosScript>();
                    pos.pos = shotpos[i[r]];


                }
            }
            onetime = false;
            time1 -= time1 * Time.deltaTime;
          
           

        }
        if(time1<1)
        {
            onetime = true;
            time = temp;
            time1 = temp2;
            change.SetInteger("Change", 0);
        }
    }
   
}
