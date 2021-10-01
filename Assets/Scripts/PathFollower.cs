using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollower : MonoBehaviour
{
    // Follows the path, decided ahead of time.
    [SerializeField] private float speed;
    [SerializeField] private float arrivalThreshold;

    private Path path;
    private Waypoint currentWaypoint;
    public float distanceToWaypoint;

    private void SetupPath()
    {
        path = FindObjectOfType<Path>();
        currentWaypoint = path.GetPathStart();
    }
    private void Update()
    {
        
        transform.LookAt(currentWaypoint.GetPosition());
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    private void PathComplete()
    {

    }
}
 