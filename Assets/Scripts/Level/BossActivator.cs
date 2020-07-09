using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossActivator : MonoBehaviour {
    public GameObject boss;
    public GameObject bar;
    public AudioSource lvl;
    public AudioSource bossmus;
    public GameObject endberry;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(boss.activeSelf==false)
        {
            endberry.SetActive(true);
        }
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            boss.SetActive(true);
            bar.SetActive(true);
            lvl.Stop();
            bossmus.Play();
        }
    }
}
