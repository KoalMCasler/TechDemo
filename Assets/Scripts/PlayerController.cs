using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Video;

public class PlayerController : MonoBehaviour
{
    private GameObject player;
    //private Rigidbody playerRB;
    public GameObject PlayerSpawner;
    public int health;
    //private Transform reSpawnTransform;
    // Start is called before the first frame update
    void Awake()
    {
        health = 3;
        player = this.gameObject;
        //playerRB = this.GetComponent<Rigidbody>(); 
        //reSpawnTransform = this.transform;
        PlayerSpawner = GameObject.FindWithTag("PlayerSpawner");
    }
    void Start()
    {
        
    }
    void Update()
    {
        if(health <= 0)
        {
            Respawn();
        }
    }
    void OnDestroy()
    {
        PlayerSpawner.GetComponent<PlayerSpawner>().ReSpawnPlayer();
    }
    void Respawn()
    {
        player.GetComponent<PlayerTeleport>().Respawn();
        health = 3; 
    }
}
