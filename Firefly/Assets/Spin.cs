using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float rot;
    void Update()
    {
        //if(transform.position.z <= 600 && transform.position.z >= 980)
        //{
           // if(transform.rotation.z < 180)
          //  {
                transform.Rotate(0,0, Time.deltaTime * rot);
           // }
       // }
    }
}
