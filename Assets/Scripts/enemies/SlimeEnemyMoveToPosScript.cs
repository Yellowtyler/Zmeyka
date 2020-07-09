using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeEnemyMoveToPosScript : MonoBehaviour
{
    public float speed;
    public float time;
    public float timedest;
    public Transform[] pos;
    public GameObject slime;
    // Use this for initialization
    private int i;
    void Start()
    {
        StartCoroutine(SlimeSpawn());
        i = 0;

    }
    // Update is called once per frame
    void Update()
    {
       
            transform.position = Vector2.MoveTowards(transform.position, pos[i].position, speed * Time.deltaTime);
            if (Vector2.Distance(transform.position, pos[i].position) == 0)
            {
                i++;
            }
        if(i==pos.Length)
        {
            i = 0;
        }
    }
    IEnumerator SlimeSpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(time);
            GameObject clone = Instantiate(slime, transform.position, Quaternion.identity);

            DestroyObject(clone, timedest);

        }
    }
}
