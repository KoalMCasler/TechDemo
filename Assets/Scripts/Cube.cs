using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public GameObject cubeGenerator;
    void Start()
    {
        cubeGenerator = GameObject.FindWithTag("CubeCannon");
    }
    void OnDestroy()
    {
        cubeGenerator.GetComponent<CubeGenerator>().CubeIsDestroyed();
    }
}
