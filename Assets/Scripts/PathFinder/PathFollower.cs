using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PathFinder
{
    /// <summary>
    /// De path follower class is verantwoordelijk voor de beweging.
    /// Deze class zorgt ervoor dat het object (in Tower Defense) vaak een enemy, het path afloopt
    /// tip: je kunt de transform.LookAt() functie gebruiken en vooruitbewegen.
    /// </summary>
    public class PathFollower : MonoBehaviour
    {   

    public Transform[] Waypoint;
    public float Speed;
    public float Arrivalthreshold = 0.1f;

    private int _currentWaypointIndex;

    private void Start()
    {
    
    }

    private void Update()
    {
        Vector3 heightOffsetPosition = new Vector3(Waypoint[_currentWaypointIndex].position.x, 
            transform.position.y, Waypoint[_currentWaypointIndex].position.z);
        float distance = Vector3.Distance(transform.position, heightOffsetPosition);

        if (distance <= Arrivalthreshold)
        {
            if (_currentWaypointIndex == Waypoint.Length-1)
            {
                print("Ik ben bij het eindpunt");
            }
            else
            {
                _currentWaypointIndex += 1;
            }
        }
        else
        {
            transform.LookAt(heightOffsetPosition);
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);    
        }
    }
    }
}

