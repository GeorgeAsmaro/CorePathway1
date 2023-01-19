using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject cube;
    
    void OnCollisionEnter(Collision hit)
    {
        
        if(hit.gameObject.tag == "DestroyBlock") {
            Destroy(cube);
        }   
    }
}
