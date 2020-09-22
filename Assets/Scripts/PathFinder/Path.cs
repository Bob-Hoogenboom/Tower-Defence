using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq; //the Linq statement is used to 'sort', 'search' & 'filter commands. in this case i used it for the 'OrderBy' command to work. 

namespace PathFinder
{
    /// <summary>
    /// De path class beheerd een array van waypoints. En houd bij bij welk waypoint een object is.
    /// Deze vormen samen het pad. 
    /// Logica die op het path niveau plaatsvindt gebeurt in deze class.
    /// Een deel van de functies welke je nodig hebt zijn hier al beschreven.
    /// </summary>
    public class Path : MonoBehaviour
    {   

        static public GameObject[] WayPoints;
        int count = 0;

        public void Awake()
        {
            WayPoints = GameObject.FindGameObjectsWithTag("WayPoint").OrderBy( go => go.name).ToArray();
            foreach (GameObject wayPoints in WayPoints)
            {
                Debug.Log(wayPoints.gameObject.name[count]);
            }
        }

        /// <summary>
        /// Deze functie returned het volgende waypoint waar naartoe kan worden bewogen.
        /// </summary>
        public WayPoints GetNextWaypoint()
        {
            // dit is nu niet goed, zorg ervoor dat het goede waypoint wordt teruggegeven.
            return null;
        }
    }
}
