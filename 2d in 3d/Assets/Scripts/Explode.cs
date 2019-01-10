using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour {

    public GameObject explosion;
    private Transform spawnpoint;

	void Start () {
        spawnpoint = gameObject.transform; //used to reference spawning coordinates and rotation
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Wall") //if it hits a wall or the player
        {
            Instantiate(explosion, spawnpoint.position, spawnpoint.rotation); //make an explosion
            Destroy(gameObject); //goodbye, dear Crusherball
        }
    }
}
