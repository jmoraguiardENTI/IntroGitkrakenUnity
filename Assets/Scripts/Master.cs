using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Master : MonoBehaviour {

    public GameObject enemyPrefab;

    public int numberOfEnemies = 5;

	// Use this for initialization
	void Start ()
    {
	    for (int i = 0; i < numberOfEnemies; i++)
        {
            GameObject.Instantiate(enemyPrefab, 
                new Vector3(Random.Range(-8, 8), Random.Range(-5, 5), 0), 
                Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
