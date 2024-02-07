using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KillBox : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if(other.CompareTag("Player"))
        {
            other.gameObject.SetActive(false);
            other.GetComponent<PlayerController>().ReSpawn();
        }
        else
        {
            Destroy(other);
        }
    }
}
