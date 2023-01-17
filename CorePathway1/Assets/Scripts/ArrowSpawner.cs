using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawner : MonoBehaviour
{

    public GameObject arrow;
    public float spawnTime;
    public float spawnDelay;
    public float destroyDelay;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawner",spawnTime,spawnDelay);
    }

    // Update is called once per frame
    void Spawner()
    {
        GameObject tempArrow = Instantiate(arrow,transform.position, Quaternion.Euler(90, 0, -90));
        Destroy(tempArrow,destroyDelay);
    }
}
