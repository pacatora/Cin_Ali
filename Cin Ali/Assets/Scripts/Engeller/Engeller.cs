using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engeller : MonoBehaviour
{
    private float speed = -3f;
    private Rigidbody2D rb2d;
    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();

    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.velocity = new Vector2(speed, 0f);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Engelyokik")
        {
            Destroy(gameObject);
        }
    }

}
