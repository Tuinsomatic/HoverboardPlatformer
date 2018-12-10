using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public Rigidbody rigb;

	// Use this for initialization
	void Start () {
        transform.position = new Vector3(23.74f, 17.08f, 5.06f);
        rigb = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("left"))
        {
            rigb.AddForce(-4, 0, 0);
        }
        if (Input.GetKey("right"))
        {
            rigb.AddForce(4, 0, 0);
        }
        if (Input.GetKey("up"))
        {
            rigb.AddForce(0, 20, 0);
        }
    }
}
