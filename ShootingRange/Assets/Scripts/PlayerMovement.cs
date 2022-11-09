using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    float movementSpeed = 5.0f;
    float viewRotationSpeed = 2.0f;
    float yaw = Mathf.Clamp(0.0f, -60f, 90f);
    float pitch = 0.0f;

    void Update()
    {
        //Move horizontally & vertically with WASD by the force of "speed"
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * movementSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * movementSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * movementSpeed);
        }

        //Makes sure the player can't move beyond these restrictions.
        if (transform.position.x < 4)
        {
            transform.position = new Vector3(4, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 8.5f)
        {
            transform.position = new Vector3(8.5f, transform.position.y, transform.position.z);
        }
        if (transform.position.z > -11.5f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -11.5f);
        }
        if (transform.position.z < -18.5f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -18.5f);
        }

        //Rotates the camera as the mouse is moved.
        yaw += viewRotationSpeed * Input.GetAxis("Mouse X");
        pitch -= viewRotationSpeed * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        transform.position = new Vector3(transform.position.x, 3, transform.position.z);
    }
}
