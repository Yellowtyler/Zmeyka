using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parts : MonoBehaviour {
    private GameObject goLeader = null;
    public List<GameObject> parts1;
    public GameObject prefab;

    private followhead lastpart;
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Berry")
        {
         
            GameObject clone = Instantiate(prefab, transform.position, Quaternion.identity);
            parts1[parts1.Count-1] = clone;
            lastpart.goLeader = parts1[parts1.Count-2];
            if (goLeader == null) return;

        }

    }
}
