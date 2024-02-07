using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KillBox : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if(!other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
        }
    }
}
