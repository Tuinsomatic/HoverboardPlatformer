using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBuildings : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x <= 63.5)
        {
            transform.position += new Vector3(0.1f, 0, 0);
        }
        else
        {
            transform.position += new Vector3(-150.77f, 0, 0);
        }
    }
}
