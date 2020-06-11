using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private Animator anim;
    private CharacterController controller;
    private PlayerControler pc;

    public float speed = 6f;
    public float turnSpeed = 60f;
    private Vector3 moveDirection = Vector3.zero;
    public float gravity = 20f;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponentInChildren<Animator>();
        controller = GetComponent<CharacterController>();
        pc = GetComponent<PlayerControler>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("up"))
        {
            anim.SetInteger("AnimPar", 1);
            pc.speed = 20f;
        }
       else if(Input.GetKey("w"))
        {
            anim.SetInteger("AnimPar", 2);
            pc.speed = 40f;
        }
        else
        {
            int counter = 10;
            anim.SetInteger("AnimPar", 0);
            Invoke("JerkOff", counter);
        }

        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        Vector3 playerMove = new Vector3(ver, 0f, hor) * speed * Time.deltaTime;
        //transform.Translate(playerMove, Space.Self);

        controller.Move(playerMove);
       //moveDirection.y -= gravity * Time.deltaTime;


    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log(collisionInfo.collider.name);
        if (collisionInfo.collider.name == "coin")
        {
            FindObjectOfType<AudioManager>().Play("talkAtCoin");
        }
    }
}

