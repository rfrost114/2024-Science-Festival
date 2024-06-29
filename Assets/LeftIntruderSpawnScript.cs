using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftIntruderSpawnScript : MonoBehaviour
{

    public GameObject defender;
    public GameObject spawner;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (defender.GetComponent<defenderSweep>().getDirection())
        {
            spawner.GetComponent<ExploringIntruderScript>().spawnRandomLeft();
        }

    }
}
