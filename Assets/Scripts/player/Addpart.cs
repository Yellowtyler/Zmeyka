using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addpart : MonoBehaviour {
    public List<Transform> BodyPart = new List<Transform>();
    public float mindistance;
    public float speed;
    public float rotationspeed;
    public GameObject bodyPrefab;
    private GameObject deleted;
    private Transform curBodyPart;
    private Transform PrevBodyPart;
    public int begin;
    public float movespeed = 0.004f;
    public int lastdel;
    public float dist;
    public GameObject spawn;
    private PlayerShootScript ammo;
    // Use this for initialization
    void Start() {
        for (int i = 0; i < begin - 1; i++)
            AddPart();
        ammo = spawn.GetComponent<PlayerShootScript>();
    }

    // Update is called once per frame
    void Update() {
        Move();
        if (Input.GetKeyDown(KeyCode.Q))
        {
            DestroyPart();
        }
        lastdel = BodyPart.Count - 1;
    }
    public void Move()
    {
        BodyPart[0].transform.position = Vector2.Lerp(BodyPart[0].transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition), movespeed*Time.deltaTime);
        Vector3 dif = Camera.main.ScreenToWorldPoint(Input.mousePosition) - BodyPart[0].transform.position;
        dif.Normalize();
        float rotz = Mathf.Atan2(dif.x, dif.y) * Mathf.Rad2Deg;

        Vector3 mouspos = Input.mousePosition;
        mouspos = Camera.main.ScreenToWorldPoint(mouspos);
        Vector2 direction = new Vector2(mouspos.x - BodyPart[0].transform.position.x, mouspos.y - BodyPart[0].transform.position.y);
        BodyPart[0].transform.up = direction;
        for (int i = 1; i < BodyPart.Count; i++)
        {
            
                curBodyPart = BodyPart[i];
                PrevBodyPart = BodyPart[i - 1];
               /* curBodyPart.transform.position = Vector2.Lerp(curBodyPart.transform.position, PrevBodyPart.transform.position, movespeed);
                Vector3 dif1 = PrevBodyPart.transform.position - curBodyPart.transform.position;
                dif1.Normalize();
                float rotz1 = Mathf.Atan2(dif1.x, dif1.y) * Mathf.Rad2Deg;
                Vector2 direction1 = new Vector2((PrevBodyPart.transform.position.x+dist) - curBodyPart.transform.position.x, (PrevBodyPart.transform.position.y+dist) - curBodyPart.transform.position.y);*/
            
                
            
             Vector3 v3FromLeader = curBodyPart.transform.position - PrevBodyPart.transform.position;
             v3FromLeader = v3FromLeader.normalized * curBodyPart.transform.localScale.y;
            // v3FromLeader = v3FromLeader.normalized;
          
            curBodyPart.transform.position = v3FromLeader + PrevBodyPart.transform.position;
            curBodyPart.transform.up = v3FromLeader;
        }
    }
    
    public void AddPart()
    {
        Transform newpart = (Instantiate(bodyPrefab, BodyPart[BodyPart.Count - 1].position, BodyPart[BodyPart.Count - 1].rotation) as GameObject).transform;

        BodyPart.Add(newpart);
    }
    public void DestroyPart()
    {
        if (BodyPart[1] != null)
        {
            deleted = BodyPart[BodyPart.Count - 1].gameObject;
            BodyPart.Remove(BodyPart[BodyPart.Count - 1]);
            DestroyObject(deleted);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Berry")
        {
            AddPart();
            ammo.ammo++;
            DestroyObject(collision.gameObject);
            //collision.gameObject.SetActive(false);
        }
    }
}

