using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatetrap : MonoBehaviour {
    public Transform rotatepos;
  public  float angl;
    public float speed;
    private Vector2 target;
    private Vector3 rotpos;
    // Use this for initialization
    void Start () {
        target = new Vector2(rotatepos.transform.position.x, rotatepos.transform.position.y);
         rotpos = new Vector3(0, 0, rotatepos.transform.rotation.z );
    }
	
	// Update is called once per frame
	void Update () {
        target = new Vector2(rotatepos.transform.position.x, rotatepos.transform.position.y);
        rotpos = new Vector3(0, 0, rotatepos.transform.rotation.z);
        transform.RotateAround(target,rotpos,angl*Time.deltaTime);
	}
}
