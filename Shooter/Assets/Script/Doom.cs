using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doom : MonoBehaviour
{
    CharacterController verdolaga;

    float speed = 10f;
    float walk = 6f;
    float jump = 12f;
    float gravity = 20f;

    private Vector3 move = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        verdolaga = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (verdolaga.isGrounded)
        {
            move = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));

            if (Input.GetKey(KeyCode.LeftShift))
            {
                move = transform.TransformDirection(move) * speed;
            }
            else
            {
                move = transform.TransformDirection(move) * walk;
            }
            if (Input.GetKey(KeyCode.Space))
            {
                move.y = jump;
            }
        }
        move.y -= gravity * Time.deltaTime;

        verdolaga.Move(move * Time.deltaTime);
    }
}
