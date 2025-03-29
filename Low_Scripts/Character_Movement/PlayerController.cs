using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Travel_Speed = 10.0f; // The speed of the character
    public float Unit_Of_Gravity = 50.0f; // A unit of gravit

    private CharacterController controller;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        // We get the entry from the player
        float Input_Horizontal = Input.GetAxis("Horizontal");
        float Input_Vertical = Input.GetAxis("Vertical");

        // We calculate the direction of movement
        Vector3 moveDirection = transform.forward * Input_Vertical + transform.right * Input_Horizontal;

        // We calculate the direction of movement
        moveDirection.y -= Unit_Of_Gravity * Time.deltaTime;

        // We move the character
        controller.Move(moveDirection * Travel_Speed * Time.deltaTime);
    }
    
}
