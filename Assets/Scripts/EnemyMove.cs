using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] List<Waypoints> path = new List<Waypoints>();
    [SerializeField] [Range(0f, 5f)]float speed = 1f;
    
    void Start()
    {
        StartCoroutine(PrintWaypointsName());
    }

    IEnumerator PrintWaypointsName()
    {
        foreach (Waypoints waypoint in path)
        {
            Vector3 startPosition = transform.position;
            Vector3 endPosition = waypoint.transform.position;
            float travelPercent = 0f;

            transform.LookAt(endPosition);

            while (travelPercent < 1f)
            { 
                travelPercent += Time.deltaTime * speed;
                transform.position = Vector3.Lerp(startPosition, endPosition, travelPercent);
                yield return new WaitForEndOfFrame();
            }
           
        }
    }

    
}
