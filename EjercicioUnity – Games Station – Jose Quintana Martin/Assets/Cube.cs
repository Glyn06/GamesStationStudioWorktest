using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Cube : MonoBehaviour
{
    Vector3 force;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.AddForce(force);
    }

    public void SetForce(Vector3 newForce)
    {
        force = newForce;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        Spawner.instance.SpawnSphereWithMovement(transform, (force * -1) / 100);
    }
}
