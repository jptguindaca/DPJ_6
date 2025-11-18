using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float maxSpeed;
    public float jumpForce = 7f;
    public float groundCheckRadius;
    public float horizontalInput;

    private bool isGrounded = true;

    public Transform groundCheck;
    public LayerMask groundLayer;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.GetComponent<Rigidbody>().freezeRotation = true;
    }

    void Start()
    {

    }


    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        transform.Translate(horizontalInput, 0, 0);


        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
        }
    }
}
