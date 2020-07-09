using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombenemy : MonoBehaviour {
    
 
    public GameObject shot;
    public float time;
    public float time1;
   public Animator anim;
    public int l;
    public bool change;
    // Use this for initialization
    void Start () {

       
        StartCoroutine(createbomb());
        //anim = GetComponent<Animator>();
        l = 0;
         change = false;
        
    }
	
	// Update is called once per frame
	void Update () {
		if(change)
        {
            l++;
        }
        if(l>=50)
        {
            anim.SetInteger("AnimationShot", 0);
            l = 0;
            change = false;
        }
	}
  
    IEnumerator createbomb()
    {
        while(true)
        {
            yield return new WaitForSeconds(time);
            anim.SetInteger("AnimationShot",1);
            change = true;
            yield return new WaitForSeconds(time1);
            Instantiate(shot, transform.position, Quaternion.identity);
           

        }
    }
  
}
