using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class movement : MonoBehaviour
{
    public float speed;
    public float jumpHeight;
    public float gravity;
    CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        if (controller.isGrounded)
        {
            move.y = Input.GetAxis("Jump") * jumpHeight;
        }
        else
        {
            move.y = transform.position.y - gravity;
        }
        
        controller.Move(move);

        //X Y Z
    }
}
