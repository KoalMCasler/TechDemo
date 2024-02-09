using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject player;
    void Start()
    {
        player = GameObject.FindWithTag("Player");
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
    void OnDestroy()
    {
        player.GetComponent<ArmCannon>().BulletIsDestroyed();
    }
}
