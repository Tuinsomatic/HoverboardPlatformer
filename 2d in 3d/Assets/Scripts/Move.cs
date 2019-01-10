using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public Rigidbody rigb;
    public AudioSource aud;

	void Start () {
        transform.position = new Vector3(18.14f, 17.08f, 5.06f); //starting position
        rigb = this.GetComponent<Rigidbody>();
	}
	
	void Update () {
		if (Input.GetKey("left"))
        {
            rigb.AddForce(-4, 0, 0); //gradually add force to the left
        }
        if (Input.GetKey("right"))
        {
            rigb.AddForce(4, 0, 0); //gradually add force to the right
        }
        if (Input.GetKey("up")) 
        {
            rigb.AddForce(0, 20, 0); //gradually add force upwards NB there is no control for down - part of the challenge is to let gravity do the work
        }
        if (Input.GetKeyDown("space"))
        {
            if (aud.isPlaying)
            {
                aud.Stop();
            }
            else
            {
                aud.Play(); //Toggle audio if it gets too annoying ;)
            }

        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.name == "right")
    //    {
    //        rigb.AddForce(-16, 0, 0);
    //    }
    //}
}
