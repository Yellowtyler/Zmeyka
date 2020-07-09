using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activesmtnh : MonoBehaviour {
    public GameObject[] something;
    public int l = 0;
    public float time;
    // Use this for initialization
    void Start () {
        
        l= 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
           
           for(int i=0;i<something.Length;i++)
            {
                something[i].SetActive(true);
            }
            gameObject.SetActive(false);
        }
    }
    
    
}
