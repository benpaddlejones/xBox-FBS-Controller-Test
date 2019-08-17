using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameLoop : MonoBehaviour
{

    public int bulletSpeed;
    public Rigidbody bulletObject;
    public Transform barrelEnd;

    private void spawnBullet()
    {
        Rigidbody b;
        b = Instantiate(bulletObject, new Vector3(barrelEnd.position.x, barrelEnd.position.y, barrelEnd.position.x), barrelEnd.rotation) as Rigidbody;
        b.AddForce(b.transform.forward * bulletSpeed);
    }

    private void Update()
    {
    if (Input.GetAxis("Fire1") > 0 || Input.GetButtonDown("Fire1"))
        {
            spawnBullet();
        }
    }

}
