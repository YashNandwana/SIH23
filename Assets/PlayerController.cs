using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float cooldown = 0.5f;
    private float previousTime = 0;
    public bool canMove = true;
    private Animator animator;
    private Rigidbody2D playerRigidBody;
    private Vector2 previousPosition;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        playerRigidBody = GetComponent<Rigidbody2D>();
        previousPosition = playerRigidBody.position;
    }

    // Update is called once per frame
    void Update()
    {
        float haxis = Input.GetAxis("Horizontal");
        float vaxis = Input.GetAxis("Vertical");

        if (Time.time > previousTime + cooldown && canMove)
        {
            Vector3 currentPosition = transform.position;
            int translateX = 0, translateY = 0;

            if (haxis != 0)
            {
                translateX = (haxis > 0) ? 1 : -1;
                if (translateX > 0)
                    transform.localScale = new Vector3(-1 * Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
                else if (translateX < 0)
                    transform.localScale = new Vector3(1 * Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
            }
            else if (vaxis != 0)
                translateY = (vaxis > 0 ? 1 : -1) * (int)Mathf.Ceil(Mathf.Abs(vaxis));

            animator.SetBool("Moving", Mathf.Max(Mathf.Abs(translateX), Mathf.Abs(translateY)) > 0);

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
