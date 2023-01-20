<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using Cursor = UnityEngine.Cursor;

public class PlayerMovement : MonoBehaviour
{

    //instance variables, organized under different groups and can be customized within unity
    [Header("Movement")]
    public float moveSpeed;

    public float groundDrag;

    public float jumpForce;
    public float jumpCooldown;
    public float airMultiplier;
    bool readyToJump;

    [Header("Keybinds")]

    public KeyCode jumpKey = KeyCode.Space;

    [Header("Ground Check")]
    public float playerHeight;
    public LayerMask ground;
    bool grounded;

    public Transform orientation;

    float horizontalInput;
    float verticalInput;

    Vector3 moveDirection;

    Rigidbody rb;

    private void Start() {

        //gets the rigidbody from unity and freezes its rotation
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;

        readyToJump = true;


    }

    private void Update() {

        //checks to see if the player is on the ground
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, ground);

        //runs the input method and makes sure the player isnt going above max speed
        MyInput();
        SpeedControl();

        //if the player is on the ground- apply drag, if not dont apply any
        if(grounded){
            rb.drag = groundDrag;
        }
        else {
            rb.drag = 0;
        }
    }

    //actually moves the game on each of the games frames
    private void FixedUpdate() {
        MovePlayer();
    }

    private void MyInput() {

        //gets the movement keys input 
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        //checks to see if the player is pressing the jump key + able to jump
        if(Input.GetKey(jumpKey) && readyToJump && grounded) {

            //temporarily says the player cannot jump
            readyToJump = false;

            //runs the jump method
            Jump();

            //makes sure players can only jump after the cooldown has ended
            Invoke(nameof(ResetJump), jumpCooldown);
        }
    }

    private void MovePlayer() {

        //calculates the direction the player is going to move in
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;

        //checks to see if the player is grounded, if they are then airMultiplier isnt taken into account, if they're in the air it is taken into account
        if(grounded){
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
        }
        else if(!grounded) { 

            rb.AddForce(moveDirection.normalized * moveSpeed * 10f * airMultiplier, ForceMode.Force);

        }
    }


    private void SpeedControl() {

        //makes sure the player doesnt go above a set speed count!!
        Vector3 flatVal = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        if(flatVal.magnitude > moveSpeed) {

            Vector3 limitedVal = flatVal.normalized * moveSpeed;
            rb.velocity = new Vector3(limitedVal.x, rb.velocity.y, limitedVal.z);
        }
    }

    private void Jump() {

        //allows the player to jump by adding upward force
        rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
    }

    private void ResetJump() {

        //allows the player to jump again
        readyToJump = true;
    }

}
=======
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using Cursor = UnityEngine.Cursor;

public class PlayerMovement : MonoBehaviour
{

    //instance variables, organized under different groups and can be customized within unity
    [Header("Movement")]
    public float moveSpeed;

    public float groundDrag;

    public float jumpForce;
    public float jumpCooldown;
    public float airMultiplier;
    bool readyToJump;

    [Header("Keybinds")]

    public KeyCode jumpKey = KeyCode.Space;

    [Header("Ground Check")]
    public float playerHeight;
    public LayerMask ground;
    bool grounded;

    public Transform orientation;

    float horizontalInput;
    float verticalInput;

    Vector3 moveDirection;

    Rigidbody rb;

    private void Start() {

        //gets the rigidbody from unity and freezes its rotation
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;

        readyToJump = true;


    }

    private void Update() {

        //checks to see if the player is on the ground
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, ground);

        //runs the input method and makes sure the player isnt going above max speed
        MyInput();
        SpeedControl();

        //if the player is on the ground- apply drag, if not dont apply any
        if(grounded){
            rb.drag = groundDrag;
        }
        else {
            rb.drag = 0;
        }
    }

    //actually moves the game on each of the games frames
    private void FixedUpdate() {
        MovePlayer();
    }

    private void MyInput() {

        //gets the movement keys input 
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        //checks to see if the player is pressing the jump key + able to jump
        if(Input.GetKey(jumpKey) && readyToJump && grounded) {

            //temporarily says the player cannot jump
            readyToJump = false;

            //runs the jump method
            Jump();

            //makes sure players can only jump after the cooldown has ended
            Invoke(nameof(ResetJump), jumpCooldown);
        }
    }

    private void MovePlayer() {

        //calculates the direction the player is going to move in
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;

        //checks to see if the player is grounded, if they are then airMultiplier isnt taken into account, if they're in the air it is taken into account
        if(grounded){
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
        }
        else if(!grounded) { 

            rb.AddForce(moveDirection.normalized * moveSpeed * 10f * airMultiplier, ForceMode.Force);

        }
    }


    private void SpeedControl() {

        //makes sure the player doesnt go above a set speed count!!
        Vector3 flatVal = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        if(flatVal.magnitude > moveSpeed) {

            Vector3 limitedVal = flatVal.normalized * moveSpeed;
            rb.velocity = new Vector3(limitedVal.x, rb.velocity.y, limitedVal.z);
        }
    }

    private void Jump() {

        //allows the player to jump by adding upward force
        rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
    }

    private void ResetJump() {

        //allows the player to jump again
        readyToJump = true;
    }

}
>>>>>>> 0db7792816b6bfca9e1ab0ac87902571a1bfec7b
