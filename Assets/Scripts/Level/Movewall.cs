using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movewall : MonoBehaviour
{
    public GameObject[] lastberry;
    public GameObject[] undeadenemy;
   private int l=0;
    public GameObject activator;
    public bool check;
    // Use this for initialization
    void Start()
    {
        l = 0;
      
    }
    // Update is called once per frame
    void Update()
    {
       
        if (activator.activeSelf == false)
        {
            
            for (int i = 0; i < lastberry.Length; i++)
            {
                if (lastberry[i].activeSelf == false)
                //if (lastberry[i] == null)
                { l++;}
            }
            if (l == lastberry.Length)
            {
                check = true;
                for (int i = 0; i < undeadenemy.Length; i++)
                {
                    DestroyObject(undeadenemy[i]);
                }
                DestroyObject(gameObject);
            }
            else
            {
                l = 0;
            }
        }
    }
}
