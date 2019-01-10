using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{

    public GameObject coin;
    private int randx;
    private int randy;
    private int randz;
    
    void Start()
    {
        StartCoroutine("Generate");
    }

    IEnumerator Generate()
    {
        for (; ; )
        {
            randx = Random.Range(-20, 15);
            randy = Random.Range(2, 20);
            Instantiate(coin, new Vector3(randx, randy, 5.06f), coin.transform.rotation);
            yield return new WaitForSeconds(10);
            //Makes a new coin somewhere random on the map every 10 seconds.
        }
    }
}

