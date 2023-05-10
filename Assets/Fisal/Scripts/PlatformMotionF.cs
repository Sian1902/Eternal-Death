using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMotionF : MonoBehaviour
{
    [SerializeField] GameObject[] waypoints;
    int waypointIndex = 0;
    public float speed=0;
    [SerializeField] public int PlatformEnabled = 0;


    public void Update()
    {
        if (waypoints[waypointIndex].activeSelf)
        {
            if (Vector2.Distance(transform.position, waypoints[waypointIndex].transform.position) < 1f)
            {
                waypointIndex++;
                if (waypointIndex >= waypoints.Length)
                {
                    waypointIndex = 0;
                }

            }
            transform.position = Vector2.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, Time.deltaTime * speed*PlatformEnabled);
        }
    }
   


}
