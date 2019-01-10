using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remove : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(gameObject, 0.3f); //Very quickly removes unwanted game objects
	}
}
