using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    // Houd een positie bij waar de enemy naar toe kan
public class Waypoint : MonoBehaviour
{
    public Vector3 GetPosition()
    {
        return transform.position;
    }
}
