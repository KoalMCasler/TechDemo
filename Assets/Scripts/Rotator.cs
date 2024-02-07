//Koal Casler
//GameDev 1
//NSCC Truro 2023

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public int RotationDegree1;
    public int RotationDegree2;
    public int RotationDegree3;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(RotationDegree1, RotationDegree2, RotationDegree3) * Time.deltaTime);    
    }
}
