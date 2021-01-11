using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    private bool _isGrounded;

    private Vector3 _velocity;

    // Update is called once per frame
    private void Update()
    {
        _isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (_isGrounded && _velocity.y < 0) _velocity.y = -2f;

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Transform transform1 = transform;
        Vector3 move = transform1.right * x + transform1.forward * z;

        Console.WriteLine(_isGrounded);
        if (Input.GetButtonDown("Jump") && _isGrounded) _velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);

        controller.Move(move * (speed * Time.deltaTime));

        _velocity.y += gravity * Time.deltaTime;

        controller.Move(_velocity * Time.deltaTime);

    }
}