using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour
{
    public float speed;
    public GameObject[] gos;
    int rand;
    private void Start()
    {
    gos = GameObject.FindGameObjectsWithTag("Gov");
    rand = Random.Range(0,gos.Length);
    }
    void Update()
    {
        
        
        GameObject closest = gos[rand];
        transform.position = Vector3.MoveTowards(transform.position, closest.transform.position, speed * Time.deltaTime);

    }

    
}
