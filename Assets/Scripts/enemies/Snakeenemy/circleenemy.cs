using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleenemy : MonoBehaviour
{
    public float speed = 1f;
    private Transform player;
    public float distance;
    private Vector2 target;
    private Vector3 targetrotate;
    public float angle;
    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);
        targetrotate = new Vector3(0, 0, player.position.z * speed);
    }

    // Update is called once per frame
    void Update()
    {

        if (Vector2.Distance(transform.position, player.position) > distance)
        {

            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);

        }
        else if (Vector2.Distance(transform.position, player.position) <= distance)
        {
            transform.RotateAround(target, targetrotate, angle * Time.deltaTime);
        }
    }
}
