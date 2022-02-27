using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfinding : MonoBehaviour
{
    public Transform[] Waypoints;
    public float minimumDistance = 2.0f; // minimum distance between the airplane and the waypoint
    public float Speed = 10.0f;
    private Transform currentWaypoint; // keep track of current waypoint
    private int currentIndex; // current position in the waypoint array

    void Start()
    {
        currentWaypoint = Waypoints[0]; // set initial waypoint
        currentIndex = 0; // set initial index
    }

    void Update()
    {
        Move();

        if (Vector3.Distance(currentWaypoint.transform.position, transform.position) < minimumDistance)
        {
            currentIndex++;
            if (currentIndex > Waypoints.Length - 1)
            {
                currentIndex = 0;
            }
            currentWaypoint = Waypoints[currentIndex];
        }
    }

    void Move()
    {
        Vector3 deltaPosition = currentWaypoint.transform.position - transform.position;
        Vector3 calcVector = deltaPosition.normalized * Speed * Time.deltaTime;
        this.transform.position += calcVector;
        this.transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(deltaPosition), 4 * Time.deltaTime);
    }

}
