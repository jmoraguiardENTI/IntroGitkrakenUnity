using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyConroller : MonoBehaviour {

    Rigidbody2D rb2D = null;
    public float speedCoefficient = 1.0f;

	// Use this for initialization
	void Start ()
    {
        rb2D = GetComponent<Rigidbody2D>();

        if (rb2D)
        {
            Vector2 direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            Vector2 initialSpeed = direction.normalized * speedCoefficient;

            rb2D.velocity = initialSpeed;
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (transform.position.y > 5)
        {
            transform.position = new Vector3(transform.position.x, -5, 0);
        }
        if (transform.position.y < -5)
        {
            transform.position = new Vector3(transform.position.x, 5, 0);
        }

        if (transform.position.x > 8)
        {
            transform.position = new Vector3(-8, transform.position.y, 0);
        }
        if (transform.position.x < -8)
        {
            transform.position = new Vector3(8, transform.position.y, 0);
        }
    }
}
