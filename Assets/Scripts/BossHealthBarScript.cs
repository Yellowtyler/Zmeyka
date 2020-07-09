using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BossHealthBarScript : MonoBehaviour {
    Image healthbar;
    float maxhealth = 100f;
    public static float health;
	// Use this for initialization
	void Start () {
        healthbar = GetComponent<Image>();
        health = maxhealth;
	}
	
	// Update is called once per frame
	void Update () {
        healthbar.fillAmount = health / maxhealth;
	}
}
