using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wom_Weapon : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject BulletPrefabs;
    private Rigidbody2D rig;
    private Collider2D coll;

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

    }

    void Shoot()
    {
        //P1����߼�
        Instantiate(BulletPrefabs,FirePoint.position,FirePoint.rotation);
    }
}
