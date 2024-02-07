using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRB;
    private Transform reSpawnTransform;
    // Start is called before the first frame update
    void Awake()
    {
        playerRB = this.GetComponent<Rigidbody>(); 
        reSpawnTransform = this.transform;
    }
    void Start()
    {
        
    }
    public void ReSpawn()
    {
        this.transform.position = reSpawnTransform.position;
        this.gameObject.SetActive(true);
    }

}
