using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour {

    public GameObject explosion;
    private Transform spawnpoint;

	// Use this for initialization
	void Start () {
        spawnpoint = gameObject.transform;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Wall")
        {
            Instantiate(explosion, spawnpoint.position, spawnpoint.rotation);
            Destroy(gameObject);
        }
    }
}
