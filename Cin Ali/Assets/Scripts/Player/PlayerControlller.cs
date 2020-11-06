using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControlller : MonoBehaviour
{
    [SerializeField]
    private AudioClip jumpclip;
    public float jumpForce=12f,rightForce=0f;
    private Rigidbody2D myRigidbody;
    private bool canJump;
    private Button JumpBtn;
    AudioSource ses;
    
    
    

        void  Awake() {
            myRigidbody=GetComponent<Rigidbody2D>();
            JumpBtn=GameObject.Find("Jump Button").GetComponent<Button>();
            JumpBtn.onClick.AddListener(()=>Jump());
            ses=GetComponent<AudioSource>();
             
        }
        public void Jump(){
            if(canJump){
                canJump=false;
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
        if(Mathf.Abs(myRigidbody.velocity.y)==0){
         canJump=true; 
         
         ses.Play(); 
         
        }
        
        
    }
}
