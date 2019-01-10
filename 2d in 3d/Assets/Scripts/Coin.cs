using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    void Start()
    {
        Destroy(gameObject, 10); //we don't want more than one coin on the map at a time.
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject); //mimics collecting the coin
             
        }
    }
}
