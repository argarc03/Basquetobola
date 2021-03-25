using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    Vector3 offset;

    public int limit;

    void Start()
    {
        InvokeRepeating("Spawn", Random.Range(0, 2), Random.Range(0, 2));
    }

    void Spawn()
    {
        offset = new Vector3(Random.Range(-limit, limit), 0.0f, Random.Range(-limit, limit));
        Instantiate(enemy, transform.position + offset, transform.rotation);
    }
}
