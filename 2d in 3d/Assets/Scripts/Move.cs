using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public Rigidbody rigb;
    public AudioSource aud;

	// Use this for initialization
	void Start () {
        transform.position = new Vector3(18.14f, 17.08f, 5.06f);
        rigb = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("left"))
        {
            rigb.AddForce(-4, 0, 0);
        }
        if (Input.GetKey("right"))
        {
            rigb.AddForce(4, 0, 0);
        }
        if (Input.GetKey("up"))
        {
            rigb.AddForce(0, 20, 0);
        }
        if (Input.GetKeyDown("space"))
        {
            if (aud.isPlaying)
            {
                aud.Stop();
            }
            else
            {
                aud.Play();
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
