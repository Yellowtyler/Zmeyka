using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeEnemyScript : MonoBehaviour {
    public float speed;
    public float time;
    public float timedest;
    private Transform player;
    public GameObject slime;
	// Use this for initialization
	
    void Awake()
    {
        StartCoroutine(SlimeSpawn());
        player = GameObject.FindGameObjectWithTag("Player").transform;
        
    }
    // Update is called once per frame
    void Update () {
        transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
	}
    IEnumerator SlimeSpawn()
    {
    while(true)
        {
            yield return new WaitForSeconds(time);
            GameObject clone =Instantiate(slime, transform.position, Quaternion.identity);
           
            DestroyObject(clone,timedest);

        }
    }
}
