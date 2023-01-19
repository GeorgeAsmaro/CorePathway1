using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMover : MonoBehaviour
{
    public float speed; 
    public GameObject arrow;
    public float delay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delay -= Time.deltaTime;
        if(delay <=0 ) {
            transform.position += (new Vector3(1,0,0) * Time.deltaTime * speed);
        }
    }
}
