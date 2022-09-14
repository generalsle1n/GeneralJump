using Microsoft.Win32.SafeHandles;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float movementSpeed;
    public float jumpHeight;
    public string horizontalAxisName;
    public string jumpAxisName;

    private bool inJump;

    private Rigidbody2D rigidbody;
    // Start is called before the first frame update
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        float xAxs = Input.GetAxis(horizontalAxisName);
        float jumpAxs = Input.GetAxis(jumpAxisName);
        Vector3 position = gameObject.transform.position;

        if(xAxs != 0 || jumpAxs != 0)
        {
            if(inJump == false)
            {
                position.y = position.y + (jumpAxs);
            }

            position.x = position.x + (xAxs * movementSpeed);
            
            rigidbody.MovePosition(new Vector2(position.x, position.y));
        }       
    }

    void OnCollisionEnter2D(Collision2D theCollision)
    {
        if (theCollision.gameObject.tag == "ground")
        {
            inJump = false;
        }
    }

    void OnCollisionExit2D(Collision2D theCollision)
    {
        if (theCollision.gameObject.tag == "ground")
        {
            inJump = true;
        }
    }
}
