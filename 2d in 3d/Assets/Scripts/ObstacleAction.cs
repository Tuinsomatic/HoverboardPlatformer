using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleAction : MonoBehaviour {

    public GameObject spawner;
    public Rigidbody rigb;

	// Use this for initialization
	void Start () {
        rigb = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        rigb.AddForce(8, 0, 0);
        Destroy(gameObject, 6);
        
	}
}
