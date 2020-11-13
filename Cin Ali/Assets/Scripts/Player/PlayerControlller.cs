using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControlller : MonoBehaviour
{
    [SerializeField]
    //------
    // ışınla bizi spock
    private AudioClip jump;
    public float jumpForce=12f,rightForce=0f;
    private Rigidbody2D myRigidbody;
    private bool canJump;
    private Button JumpBtn;
    AudioSource ses;
    [SerializeField] private Transform feetTransform;
    
    bool isGrounded(){

        RaycastHit2D rayHit = Physics2D.Raycast(feetTransform.position, Vector2.down);
        if(Vector2.Distance(new Vector2(feetTransform.position.x, feetTransform.position.y), rayHit.point) <= 0f){
            return true;
        }
        
        else
            return false;
    }
    

        void  Awake() {
            myRigidbody=GetComponent<Rigidbody2D>();
            JumpBtn=GameObject.Find("Jump Button").GetComponent<Button>();
            JumpBtn.onClick.AddListener(()=>Jump());
            ses=GetComponent<AudioSource>();
             
        }
        public void Jump(){
            if(isGrounded()){
                
                ses.Play();
                if(transform.position.x<0){
                    rightForce=0f;
                                        
                }
                else{
                    rightForce=0;
                }
                myRigidbody.velocity=new Vector2(rightForce,jumpForce);
            }
        }
    
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
