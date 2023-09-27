using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float movementSpeed = 1;
    public float jumpheight = 10;
    public float mousexspeed = 1;
    Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        float mouseXInput = Input.GetAxis("Mouse X");

        transform.position += transform.forward * verticalInput * movementSpeed;
        transform.position += transform.right * horizontalInput * movementSpeed;

        transform.Rotate(0, mouseXInput * mousexspeed, 0);

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            rigid.AddForce(Vector3.up * jumpheight);
        }
    }
}
