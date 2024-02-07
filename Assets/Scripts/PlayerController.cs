using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private GameObject player;
    private Rigidbody playerRB;
    public GameObject PlayerSpawner;
    //private Transform reSpawnTransform;
    // Start is called before the first frame update
    void Awake()
    {
        player = this.gameObject;
        playerRB = this.GetComponent<Rigidbody>(); 
        //reSpawnTransform = this.transform;
        PlayerSpawner = GameObject.FindWithTag("PlayerSpawner");
    }
    void Start()
    {
        
    }
    void OnDestroy()
    {
        PlayerSpawner.GetComponent<PlayerSpawner>().ReSpawnPlayer();
    }
}
