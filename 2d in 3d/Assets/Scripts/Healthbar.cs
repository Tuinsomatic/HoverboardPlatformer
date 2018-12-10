using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthbar : MonoBehaviour {

    public Damage damage;


	// Use this for initialization
	void Start () {
        transform.localScale = new Vector3(10, 0.2f, 0);
	}
	
	// Update is called once per frame
	void Update () {
        transform.localScale = new Vector3(damage.health/10f +0.2f, 0.2f, 0);
        if (transform.localScale.x < 0)
        {
            transform.localScale = new Vector3(0, 0.2f, 0);
        }
    }
}
