using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour {
    private Animator anim;
    void Awake() {
        anim= GetComponent<Animator>();

        void OnCollisionEnter2D(Collision2D hedef) {
            if(hedef.gameObject.tag=="Engel"){
                anim.Play("idle");
            }
            
        }
        void OnCollisionExit2D(Collision2D hedef) {
            if(hedef.gameObject.tag=="Engel"){
                anim.Play("run"); }
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}}
