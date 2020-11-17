using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControlller : MonoBehaviour
{
    [SerializeField] private AudioClip jump;
    [SerializeField] private GameObject endGameScreen, yolText;
    public float jumpForce = 4f, rightForce = 0f;
    private Rigidbody2D myRigidbody;
    private bool canJump;
    private Button JumpBtn;
    AudioSource ses;
    [SerializeField] private Transform feetTransform;

    private float jumpTimeCounter;
    public float jumpTime;

    bool isGrounded()
    {

        RaycastHit2D rayHit = Physics2D.Raycast(feetTransform.position, Vector2.down);
        if (Vector2.Distance(new Vector2(feetTransform.position.x, feetTransform.position.y), rayHit.point) <= 0f)
        {
            return true;
        }

        else
            return false;

    }

    void Awake()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        ses = GetComponent<AudioSource>();
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (isGrounded() && (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)))
        {
            ses.Play();
            jumpTimeCounter = jumpTime;
            myRigidbody.velocity = new Vector2(1f, jumpForce);
        }

        else if (Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0))
        {
            if (jumpTimeCounter > 0)
            {
                myRigidbody.velocity = new Vector2(1f, jumpForce);
                jumpTimeCounter -= Time.deltaTime;
            }

        }

        else
        {
            ses.Stop();
            myRigidbody.velocity = new Vector2(1f, myRigidbody.velocity.y);
            jumpTimeCounter = 0f;
        }


        Camera.main.transform.position = new Vector3(transform.position.x + 3f, 0f, transform.position.z - 15f);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            endGameScreen.SetActive(true);
            endGameScreen.transform.GetChild(2).GetComponent<Text>().text += yolText.GetComponent<Text>().text;
            Time.timeScale = 0f;
        }
    }
}
