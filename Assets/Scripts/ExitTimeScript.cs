using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitTimeScript : MonoBehaviour {
    public float time1;
    public GameObject[] enemies;
    public GameObject act;
    bool check;
	// Use this for initialization
	void Start () {
        StartCoroutine(time());
        check = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(act.activeSelf==true)
        {
            check = true;
            gameObject.SetActive(true);
        }
	}
    IEnumerator time()
    {
        while(check)
        {
            yield return new WaitForSeconds(time1);
            for(int i=0;i<enemies.Length;i++)
            {
                DestroyObject(enemies[i]);
            }

            DestroyObject(gameObject);
        }
    }
}
