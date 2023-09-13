using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float cooldown = 0.5f;
    private float previousTime = 0;
    private Rigidbody2D playerRigidBody;
    private Vector2 previousPosition;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();
        previousPosition = playerRigidBody.position;
    }

    // Update is called once per frame
    void Update()
    {
        float haxis = Input.GetAxis("Horizontal");
        float vaxis = Input.GetAxis("Vertical");

        if (Time.time > previousTime + cooldown)
        {
            Vector3 currentPosition = transform.position;
            int translateX = 0, translateY = 0;


            if (haxis != 0)
                translateX = (haxis > 0 ? 1 : -1) * (int)Mathf.Ceil(Mathf.Abs(haxis));
            else if (vaxis != 0)
                translateY = (vaxis > 0 ? 1 : -1) * (int)Mathf.Ceil(Mathf.Abs(vaxis));

            previousPosition = playerRigidBody.position;
            playerRigidBody.MovePosition(currentPosition + new Vector3(translateX, translateY));
            previousTime = Time.time;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(previousPosition);
        transform.position = previousPosition;
    }
}
