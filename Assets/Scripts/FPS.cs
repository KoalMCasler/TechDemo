using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.InputSystem;

public class FPS : MonoBehaviour
{
    [Header("Object References")]
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private Rigidbody playerRB;
    [SerializeField]
    private Camera fpsCamera;
    [SerializeField]
    private PlayerController PlayerController;
    [SerializeField]
    private GameObject crouchedPlayer;
    [Header("Movement Settings")]
    private Vector3 walkInput;
    private Vector3 moveValue;
    [SerializeField]
    private float speedMultiplier;
    [SerializeField]
    private float sprintMultiplier;
    [SerializeField]
    private float crouchMultiplier;
    [SerializeField]
    private int jumpForce;
    //[SerializeField]
    //private float gravity;
    [SerializeField]
    private float currentSpeed;
    [SerializeField]
    private bool isSprinting;
    [SerializeField]
    private bool isCrouching;
    [SerializeField] 
    private Transform groundCheck;
    [SerializeField] 
    private Transform roofCheck;
    [SerializeField] 
    private LayerMask ground;
    private Vector3 speedVector;
    private float verticalRotation;
    [SerializeField]
    private Vector3 moveVector3;
    [SerializeField]
    private Vector3 originalScale;
    [SerializeField]
    public int moveSpeed;
    public int maxMoveSpeed;
    public int minMoveSpeed;
    public Transform crouchedTransform;
    [Header("Look Settings")]
    [SerializeField]
    private float lookSensitivity;
    [SerializeField]
    private float upDownLimit;

    
    
    // Start is called before the first frame update
    void Start()
    {
        originalScale = player.transform.localScale;
        crouchedTransform.localScale = crouchedPlayer.transform.localScale; 
        isCrouching = false;
        isSprinting = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        playerRB = this.GetComponent<Rigidbody>();
        player = gameObject;
        PlayerController = player.GetComponent<PlayerController>();
        fpsCamera = Camera.main;
        if(moveSpeed < minMoveSpeed || moveSpeed > maxMoveSpeed)
        {
            moveSpeed = minMoveSpeed;
        }
        if(jumpForce < 1)
        {
            jumpForce = 1;
        }
        if(upDownLimit < 60 || upDownLimit > 80)
        {
            upDownLimit = 70;
        }
        if(sprintMultiplier <= 0)
        {
            sprintMultiplier = 1.5f;
        }
        if(crouchMultiplier <= 0 || crouchMultiplier > 1)
        {
            crouchMultiplier = 0.75f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        ManageLook();
        ManageInput();
        SpeedTest();
    }
    void ManageInput()
    {
        // movement logic
        if(isSprinting == true && isCrouching == false)
        {
            player.transform.localScale = originalScale;
            //Debug.Log("Is sprinting");
            gameObject.transform.Translate(moveVector3*Time.deltaTime*moveSpeed*sprintMultiplier);
        }
        if(isCrouching == true)
        {
            //Debug.Log("Is Crouching");
            gameObject.transform.Translate(moveVector3*Time.deltaTime*moveSpeed*crouchMultiplier);
            player.transform.localScale = crouchedPlayer.transform.localScale;  
        }
        if(isCrouching != true)
        {
            player.transform.localScale = originalScale; 
        }
        if(isSprinting == false && isCrouching == false)
        {
            player.transform.localScale = originalScale;
            gameObject.transform.Translate(moveVector3*Time.deltaTime*moveSpeed);
        }
    }
    void OnSprint()
    {
        if(IsSprinting())
        {
            Debug.Log("Player Started to sprint");
        }
        else
        {
            Debug.Log("Player stopped sprinting");
        }

    }
    void OnCrouch()
    {
        if(IsCrouched())
        {
            Debug.Log("Player Crouched");
        }
        else
        {
            Debug.Log("Player UnCrouched");
        }
    }
    void OnJump()
    {
        if(IsGrounded())
        {
            moveVector3.y = jumpForce;
            Debug.Log("Player Jumped");
        }
        else
        {
            Debug.Log("Player is not grounded");
        }
    }

    void OnMove(InputValue movementValue)
    {
        // Extracting player input
        Vector2 moveVector2 = movementValue.Get<Vector2>();
        moveVector3 = new Vector3(moveVector2.x, 0, moveVector2.y);
        // Make player move
        //gameObject.transform.Translate(moveVector3*Time.deltaTime);
        //Debug.Log("Input value: "+ moveVector3);
    }
    void ManageLook()
    {
        float mouseXRotation = Input.GetAxis("Mouse X") * lookSensitivity;
        float mouseYRotation = Input.GetAxis("Mouse Y");
        player.transform.Rotate(0f,mouseXRotation,0f);
        verticalRotation -= mouseYRotation * lookSensitivity;
        verticalRotation = Mathf.Clamp(verticalRotation,-upDownLimit,upDownLimit);
        fpsCamera.transform.localRotation = Quaternion.Euler(verticalRotation,0,0);
    }
    void SpeedTest()
    {
        // Tests player speed
        //speedVector = playerController.velocity;
        //currentSpeed = speedVector.magnitude;
    }
    bool IsGrounded()
    {
        return Physics.CheckSphere(groundCheck.position, .1f, ground);
    }
    bool IsUnderRoof()
    {
        return Physics.CheckSphere(roofCheck.position, .1f, ground);
    }
    bool IsCrouched()
    {
        if(isCrouching == false)
        {
            isCrouching = true;
        }
        else
        {
            isCrouching = false;
        }
        return isCrouching;
    }
    bool IsSprinting()
    {
        if(isSprinting == false)
        {
            isSprinting = true;
        }
        else
        {
            isSprinting = false;
        }
        return isSprinting;
    }

}
