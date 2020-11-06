using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engelyokik : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D hedef){
        if(hedef.tag=="Engelyokik"){
            gameObject.SetActive(false);
        }
    }
        
    }

