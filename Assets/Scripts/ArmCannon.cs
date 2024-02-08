using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmCannon : MonoBehaviour
{
    public GameObject armCannon;
    public GameObject projectile;
    private GameObject bullet;
    private Rigidbody bulletRB;
    public int BulletForce;
    public bool bulletIsAlive;
    void Start()
    {
        if(BulletForce <= 1)
        {
            BulletForce = 2;
        }

    }
    void OnFire()
    {
        if(bulletIsAlive != true)
        {
            bulletIsAlive = true;
            bullet = GameObject.Instantiate(projectile, armCannon.transform);
            bulletRB = bullet.GetComponent<Rigidbody>();
            bulletRB.AddForce(Vector3.forward*BulletForce);
        }
        else
        {
            Destroy(bullet);
        }
    }

}
