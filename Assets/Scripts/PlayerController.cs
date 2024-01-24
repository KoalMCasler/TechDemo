using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // on move is called every input action
    void OnMove(InputValue movementValue)
    {
        // Extracting player input
        Vector2 moveVector2 = movementValue.Get<Vector2>();
        Vector3 moveVector3 = new Vector3(moveVector2.x, 0, moveVector2.y);
        // Make player move
        gameObject.transform.Translate(moveVector3);
        Debug.Log("Input value: "+ moveVector3);
    }
}
