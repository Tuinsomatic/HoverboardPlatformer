using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {

    public int health = 100;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (health < 0)
        {
            Destroy(gameObject);
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            health -= 5;
        }
        else if (collision.gameObject.tag == "Ground")
        {
            health -= 10;
        }
    }
}
