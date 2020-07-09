using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDestroyZoneScript : MonoBehaviour {
   public Bossscirpt hp;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(gameObject.activeSelf==true)
        {
            hp.hp--;
            BossHealthBarScript.health -= 10f;
        }
    }
}
