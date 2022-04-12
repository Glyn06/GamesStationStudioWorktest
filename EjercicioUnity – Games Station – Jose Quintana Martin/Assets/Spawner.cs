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

    List<Sphere> spheres;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        spheres = new List<Sphere>();
    }

    public void SpawnCube(Transform origin) {
        GameObject obj = Instantiate(cubePrefab, origin.position, Quaternion.identity);
        obj.GetComponent<Cube>().SetForce(cubeInitialForce);
    }

    public void SpawnSphere(Transform origin)
    {
        GameObject obj = Instantiate(spherePrefab, origin.position, Quaternion.identity);
        Sphere sphere = obj.GetComponent<Sphere>();
        sphere.SetForce(sphereInitialForce);
        spheres.Add(sphere);
    }

    public void SpawnSphereWithMovement(Transform origin, Vector3 newMovement)
    {
        GameObject obj = Instantiate(spherePrefab, origin.position, Quaternion.identity);
        obj.GetComponent<Sphere>().SetForce(newMovement);
    }

    public void DestroyAllSpheres() {

        foreach (Sphere sphere in spheres)
        {
            if (sphere != null)
                Destroy(sphere.gameObject);
        }

        spheres.Clear();
    }
}
