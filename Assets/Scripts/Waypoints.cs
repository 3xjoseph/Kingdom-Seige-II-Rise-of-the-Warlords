using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    [SerializeField] bool isPlaceable;

   void OnMouseDown() 
   {
        if (isPlaceable)
        {
            Debug.Log(transform.name);
        }
        
   }
}
