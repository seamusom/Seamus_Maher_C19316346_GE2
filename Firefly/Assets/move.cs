using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
   
    public float Dist;

    // Update is called once per frame
    void Update()
    {

        if(transform.position.z <= Dist)
            transform.Translate( Vector3.forward * speed * Time.deltaTime);
        
    }
}
