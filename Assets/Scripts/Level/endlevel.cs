using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
public class endlevel : MonoBehaviour {
    public int index;
   public AudioSource audioa;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        string s;
        int lvlup;
        string path = @"progress.txt";
        if(collision.tag=="Player")
        {
            using (StreamReader f = File.OpenText(path))
            {
                s = f.ReadLine();
            }
            lvlup = Int32.Parse(s);
            lvlup++;
            using (StreamWriter f = new StreamWriter(path, false))
            {
                f.WriteLine(lvlup);
            }
                audioa.time = 2;
            audioa.Play();
            Application.LoadLevel(index);
          
        }
        else
        {
            DestroyObject(collision.gameObject);
        }
    }
}
