using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    // Een verzameling van waypoints
    [SerializeField] private Waypoint[] waypoints;
    public Waypoint GetPathStart()
    {
        return waypoints[0];
    }
    public Waypoint GetPathEnd()
    {
        return waypoints[waypoints.Length - 1];
    }
    public Waypoint GetNextWaypoint(Waypoint currentWaypoint)
    {
        return waypoints[0];
    }
}
