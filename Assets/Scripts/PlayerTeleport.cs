using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    // Game object used to take the transform of teleport destination
    [SerializeField]
    private GameObject currentTeleport;
    // Attachment for transition effect
    //public Animator transition;
    // Adjustable delay for transition effect
    public float TransitionTime = 0.3f;
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private GameObject playerSpawnPosition;   
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        playerSpawnPosition = GameObject.FindWithTag("PlayerSpawner");
    }
    // Input check
    void Update()
    {
    //     if (Input.GetButtonDown("Interact"))
    //     {
    //         StartCoroutine(Teleport());
    //     }
    }

    private void OnTriggerEnter(Collider collision)
    {
        // grabs destination on entering location of tagged object.
        if (collision.CompareTag("Teleport"))
        {
            currentTeleport = collision.gameObject;
        }
        if (collision.CompareTag("KillBox"))
        {
            Debug.Log("Player touched kill box");
            currentTeleport = playerSpawnPosition;
            StartCoroutine(Teleport());
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        // nulls destination on exit of area to prevent teleport when not over object
        if (collision.CompareTag("Teleport"))
        {
            if (collision.gameObject == currentTeleport)
            {
                currentTeleport = null;
            }
        }
    }
    // Coroutine used to delay teleport only after transition effect is started 
    private IEnumerator Teleport()
    {
        // uses destination from DoorTP script to move player
        if (currentTeleport != null)
            {
                //transition.SetBool("Start", true);
                yield return new WaitForSeconds(TransitionTime);
                player.transform.position = (currentTeleport.GetComponent<Teleport>().GetDestination().position);
                //transition.SetBool("Start", false);
            }
    }
}
