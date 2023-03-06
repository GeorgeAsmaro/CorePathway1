using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cube;
    public float spawnTime;
    public float spawnDelay;
    public bool canSpawn = false;
    
    // Update is called once per frame
    void Spawner()
    {
        if(canSpawn) {
            GameObject tempCube = Instantiate(cube,transform.position, Quaternion.Euler(90, 0, -90));
            canSpawn = false;
        }
    }
}
