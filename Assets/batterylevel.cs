using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class batterylevel : MonoBehaviour
{
    public GameObject bldisplay;
    private float batteryLevel;  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        batteryLevel = SystemInfo.batteryLevel;
    }

}
