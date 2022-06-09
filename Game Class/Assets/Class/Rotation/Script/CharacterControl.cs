using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{

    CharacterController characterController;

    public float speed = 1.0f;

    public float mouseSpeed = 100.0f;

    float x, z;

    bool jump = false;

    Vector3 direction;
    // Start is called before the first frame update
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");

        direction = new Vector3(x,0,z);

        characterController.Move(direction.normalized * speed * Time.deltaTime);
        //                X     Y                                                    Z  space
        transform.Rotate(0f, Input.GetAxis("Mouse X") * mouseSpeed * Time.deltaTime, 0, Space.World);

    }

}
