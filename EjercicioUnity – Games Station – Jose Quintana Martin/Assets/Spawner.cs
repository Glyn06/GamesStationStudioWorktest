using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public static Spawner instance;

    [SerializeField] GameObject cubePrefab;
    [SerializeField] GameObject spherePrefab;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void SpawnCube(Transform origin) {
        Instantiate(cubePrefab, origin.position, Quaternion.identity);
    }

    public void SpawnSphere(Transform origin)
    {
        Instantiate(spherePrefab, origin.position, Quaternion.identity);
    }
}
