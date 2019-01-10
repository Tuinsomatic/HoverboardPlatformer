using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleAction : MonoBehaviour {

    public GameObject spawner;
    public Rigidbody rigb;

	void Start () {
        rigb = this.GetComponent<Rigidbody>();
	}
	
	void Update () {
        rigb.AddForce(8, 0, 0); //hurtle yourself in the player's direction.
        Destroy(gameObject, 6); //Nothing lasts forever.
        
	}
}
