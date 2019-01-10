using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBuildings : MonoBehaviour {

	void Update () {
        if (transform.position.x <= 63.5)
        {
            transform.position += new Vector3(0.1f, 0, 0); //creates the illusion that everything in the foreground is moving
        }
        else
        {
            transform.position += new Vector3(-150.77f, 0, 0); //once out of sight, loop back to the other side of the screen
        }
    }
}
