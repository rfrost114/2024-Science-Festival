using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RightIntruderSpawnScript : MonoBehaviour
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
       if (!defender.GetComponent<defenderSweep>().getDirection())
        {
            spawner.GetComponent<ExploringIntruderScript>().spawnRandomRight();
        }

    }

}
