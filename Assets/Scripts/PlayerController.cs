using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2D = null;

    public float rotationCoefficient = 50.0f;
    public float accelerationCoefficient = 50.0f;

    // Use this for initialization
    void Start ()
    {
        rb2D = GetComponent<Rigidbody2D>();
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
    private void FixedUpdate()
    {
        transform.Rotate(0, 0, -Input.GetAxis("Horizontal") * Time.deltaTime * rotationCoefficient);

        rb2D.AddForce(Input.GetAxis("Vertical") * transform.up * accelerationCoefficient);
    }
}
