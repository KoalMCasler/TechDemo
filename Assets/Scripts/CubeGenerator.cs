using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    public GameObject cube;
    public bool CubeIsAlive;
    public Vector3 SpawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        CubeIsAlive = false;
    }

    // Update is called once per frame
    void Update()
    {
        //GameObject.Instantiate(cube, gameObject.transform);
        if(CubeIsAlive == false)
        {
            CreateCube();
        }
    }
    void CreateCube()
    {
        GameObject.Instantiate(cube, gameObject.transform);
        CubeIsAlive = true;
    }
    public void CubeIsDestroyed()
    {
        CubeIsAlive = false;
    }
}
