using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject player;
    private ArmCannon playerAC;
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        playerAC = player.GetComponent<ArmCannon>();
        Invoke("KillObject",5);
    }
    void KillObject()
    {
        Destroy(this);
    }
    public void OnCollisionEnter(Collision other)
    {
        //other.gameObject.GetComponent<Material>().color
    }
    void OnDestory()
    {
        playerAC.bulletIsAlive = false;
    }
}
