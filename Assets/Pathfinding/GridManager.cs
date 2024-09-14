using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] Node node;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(node.coordinates);
        Debug.Log(node.isWalkable);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
