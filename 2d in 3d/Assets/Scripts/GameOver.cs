using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

    public Damage dmg;
    public RectTransform rec;
    public GameManager manager;

    private bool showing = false;
    private int counter = 0;

	// Use this for initialization
	void Start () {
        StartCoroutine("EndGame");
	}
	
	IEnumerator EndGame()
    {
        for(; ; )
        {
            if (dmg.gameOver == true)
            {
                if (showing == false)
                {
                    rec.position = new Vector3(538, 100, 0);
                    showing = true;
                    counter += 1;
                }
                else
                {
                    rec.position = new Vector3(-538, 100, 0);
                    showing = false;
                }

            }
            if (counter >= 4)
            {
                manager.BackToMainMenu();
            }
            yield return new WaitForSeconds(0.75f);
        }
    }
}
