using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBox : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            other.GetComponent<PlayerController>().health -= 1;
        }
    }
    void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            for(float i = 0; i < 1; i += Time.deltaTime)
            {
                other.GetComponent<PlayerController>().health -= 1;
                i = 0;
            }
        }
    }
}
