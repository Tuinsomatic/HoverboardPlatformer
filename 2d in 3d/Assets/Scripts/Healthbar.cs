using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthbar : MonoBehaviour {

    public Damage damage;


	void Start () {
        transform.localScale = new Vector3(10, 0.2f, 0); //full health bar
	}
	
	void Update () {
        transform.localScale = new Vector3(damage.health/10f +0.2f, 0.2f, 0); //keeps up to date with the player's health every frame
        if (transform.localScale.x < 0)
        {
            transform.localScale = new Vector3(0, 0.2f, 0); //stops the health bar going negative
        }
    }
}
