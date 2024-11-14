using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointManager : MonoBehaviour
{
    private float points = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void IncrementPoints()
    {
        points++;
        Debug.Log(points);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
