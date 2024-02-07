using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDoor : MonoBehaviour
{
    public Animator doorAnim;
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            doorAnim.SetBool("DoorIsOpen",true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            doorAnim.SetBool("DoorIsOpen",false);
        }
    }
}
