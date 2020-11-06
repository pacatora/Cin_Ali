using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engeller : MonoBehaviour
{
    private float speed= -3f;
    private Rigidbody2D myRigidBody;
    void Awake() {
        myRigidBody=GetComponent<Rigidbody2D>();
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myRigidBody.velocity=new Vector2(speed,0f);
        
    }
}
