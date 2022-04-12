using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject cubePrefab;
    [SerializeField] GameObject spherePrefab;

    public void SpawnCube() {
        Instantiate(cubePrefab, transform.position, Quaternion.identity);
    }

    public void SpawnSphere()
    {
        Instantiate(spherePrefab, transform.position, Quaternion.identity);
    }
}
