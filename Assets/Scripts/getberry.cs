using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class getberry : MonoBehaviour {
    public GameObject partsnake;
    private int count;
    public Text counttext;
    public Addpart newapart;
    bool check = false;
	// Use this for initialization
	void Start () {
        count = 0;
        countscore();
	}
	
	// Update is called once per frame
	void Update () {
       if(check==true)
        {
           
            newapart.AddPart();
            DestroyObject(gameObject);
        }
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            check = true;
           

        }
    }
    void countscore()
    {
        counttext.text = "Count: " + count.ToString();

    }
}
