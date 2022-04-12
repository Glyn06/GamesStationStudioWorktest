using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Sphere : MonoBehaviour
{

    Vector3 movement;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        movement.y -= 9.8f;
        transform.Translate(movement * Time.fixedDeltaTime);
    }

    public void SetForce(Vector3 newForce)
    {
        movement = newForce;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
