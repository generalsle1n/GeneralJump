using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float movementSpeed;
    public string horizontalAxisName;
    public float jumpAxisName;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        float xAxs = Input.GetAxis(horizontalAxisName);

        if(xAxs != 0)
        {
            Vector3 position = gameObject.transform.position;
            Vector3 position2 = gameObject.transform.position;
            position.x = position.x + (xAxs * movementSpeed);

            gameObject.transform.position = position;
        }        
    }
}
