using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

    public GameObject obst;
    public GameObject rot;
    private int randone;
    public GameObject player;

	void Start () {
        StartCoroutine("Generate");
	}

    IEnumerator Generate()
    {
        for(; ; )
        {
            randone = Random.Range(2, 29);
            Instantiate(obst, new Vector3(-30, randone, 5.06f), rot.transform.rotation);
            Instantiate(obst, new Vector3(-30, player.transform.position.y, 5.06f), rot.transform.rotation);
            yield return new WaitForSeconds(1);
            //Every second, 2 Crusherballs are spawned. One is on the same Y level as the player and the other is at a random Y level.
        }   
    }
}
