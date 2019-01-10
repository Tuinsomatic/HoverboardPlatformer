using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {

    public int health = 100;
    public bool gameOver = false;

    public GameObject explosion;
    private Transform spawnpoint;

    void Start () {
        spawnpoint = gameObject.transform;
    }
	
	void Update () {
		if (health < 0)
        {
            Instantiate(explosion, spawnpoint.position, spawnpoint.rotation); //player explodes if on 0 health
            Destroy(gameObject);
            gameOver = true; //used to trigger the "GAME OVER" text appearing
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            health -= 5; //-5 health for touching a Crusherball
        }
        else if (collision.gameObject.tag == "Ground")
        {
            health -= 10; //-10 health for touching the ground
        }
    }
}
