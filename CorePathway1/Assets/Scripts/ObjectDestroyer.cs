using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject cube;
    void Start() {
        InvokeRepeating("Spawner", 0f, 2f);
    }

    void Spawner() {
        GameObject tempCube = Instantiate(cube,transform.position, Quaternion.Euler(90, 0, -90));
    }
    // Update is called once per frame
    void OnCollisionEnter(Collision hit)
    {
        
        if(hit.gameObject.tag == "DestroyBlock") {
            Destroy(cube);
        }   
    }
}
