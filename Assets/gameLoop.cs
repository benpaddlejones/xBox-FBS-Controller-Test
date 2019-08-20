using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameLoop : MonoBehaviour
{

    public int ballSpeed;
    public Rigidbody ballObject;
    public Transform ballSpawnPoint;

    private void spawnBall()
    {
        Rigidbody b;
        b = Instantiate(ballObject, new Vector3(ballSpawnPoint.position.x, ballSpawnPoint.position.y, ballSpawnPoint.position.z), ballSpawnPoint.rotation) as Rigidbody;
        b.AddForce(b.transform.forward * ballSpeed);
    }

    private void Update()
    {
    if (Input.GetAxis("Fire1") > 0 || Input.GetButtonDown("Fire1"))
        {
            spawnBall();
        }
    }

}
