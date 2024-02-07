using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    // Transform of object set as destination from object.
    [SerializeField] 
    private Transform destination;

    public Transform GetDestination()
    {
        return destination;
    }
}
