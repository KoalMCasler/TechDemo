using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject player;
    public Transform reSpawnTransform;
    [SerializeField]
    private bool playerIsAlive;
    // Start is called before the first frame update
    void Start()
    {
        reSpawnTransform = this.transform;
        playerIsAlive = true;
        player = GameObject.Instantiate(playerPrefab, reSpawnTransform);
    }
    void Update()
    {
        if(playerIsAlive == false)
        {
            player = GameObject.Instantiate(playerPrefab, reSpawnTransform);
        }
    }
    public void ReSpawnPlayer()
    {
        playerIsAlive = false;
    }
}
