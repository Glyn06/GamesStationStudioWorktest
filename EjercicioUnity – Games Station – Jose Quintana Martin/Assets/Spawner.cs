using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public static Spawner instance;

    [SerializeField] GameObject cubePrefab;
    [SerializeField] GameObject spherePrefab;

    [SerializeField] Vector3 cubeInitialForce;
    [SerializeField] Vector3 sphereInitialForce;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void SpawnCube(Transform origin) {
        GameObject obj = Instantiate(cubePrefab, origin.position, Quaternion.identity);
        obj.GetComponent<Cube>().SetForce(cubeInitialForce);
    }

    public void SpawnSphere(Transform origin)
    {
        GameObject obj = Instantiate(spherePrefab, origin.position, Quaternion.identity);
        obj.GetComponent<Sphere>().SetForce(sphereInitialForce);
    }

    public void SpawnSphereWithMovement(Transform origin, Vector3 newMovement)
    {
        GameObject obj = Instantiate(spherePrefab, origin.position, Quaternion.identity);
        obj.GetComponent<Sphere>().SetForce(newMovement);
    }
}
