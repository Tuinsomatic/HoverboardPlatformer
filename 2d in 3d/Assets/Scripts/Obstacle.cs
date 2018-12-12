using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

    public GameObject obst;
    public GameObject rot;
    private int randone;
    public GameObject player;

	// Use this for initialization
	void Start () {
        StartCoroutine("Generate");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator Generate()
    {
        for(; ; )
        {
            randone = Random.Range(2, 29);
            Instantiate(obst, new Vector3(-30, randone, 5.06f), rot.transform.rotation);
            Instantiate(obst, new Vector3(-30, player.transform.position.y, 5.06f), rot.transform.rotation);
            yield return new WaitForSeconds(1);

        }   
    }
}
