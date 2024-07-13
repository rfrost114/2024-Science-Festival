using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegionMarkerScript : MonoBehaviour
{

    public GameObject marker;
    // Start is called before the first frame update
    void Start()
    {
        marker.GetComponent<Renderer>().enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
