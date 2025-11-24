using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Transactions;
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
        rb.freezeRotation = true;
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

            Jump();
        }

        
       
    }
    private void FixedUpdate()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundCheckRadius, groundLayer);
        
        Vector3 velocity = rb.linearVelocity;

        float targetVelX = horizontalInput * moveSpeed;

        float newVelX = Mathf.MoveTowards(velocity.x, targetVelX, 50f * Time.fixedDeltaTime);

        rb.linearVelocity = new Vector3(Mathf.Clamp(newVelX, -maxSpeed, maxSpeed), velocity.y, 0f);

        

            
    }

    public void Jump()
    {
        
        Vector3 speed = rb.linearVelocity;

        speed.y = 0f;


        rb.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
       
       




    }
}
