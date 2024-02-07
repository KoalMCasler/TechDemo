using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    public  NewInput controls;
    public GameObject Player;

    private Vector3 offSet;
    
    void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        offSet = transform.position - Player.transform.position;
    }

    // Update is called once per frame after everything else.
    void LateUpdate()
    {
        transform.position = Player.transform.position + offSet;
    }
}
