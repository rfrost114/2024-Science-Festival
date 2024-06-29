using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExploringIntruderScript : MonoBehaviour
{
    public GameObject intruder;
    public GameObject fiveIntruder;
    public GameObject reset;
    private Vector3 leftLocation = new Vector3(-8f, 0.5f);
    private Vector3 rightLocation = new Vector3(8f, 0.5f);
    public bool intruderReleased = false;
    public GameObject defender;
    public float intruderRate = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void spawnRandomIntruder()
    {

        if (Random.Range(0f, 1f) > .5)
        {
            Instantiate(intruder, leftLocation, transform.rotation);
        }
        else
        {
            Instantiate(intruder, rightLocation, transform.rotation);
        }
    }

    private void spawnIntruder(GameObject newIntruder)
    {

        newIntruder.GetComponent<IntruderScript>().SetVelocity(3.0f);
    }

    public void spawnOneLeft()
    {
        intruderReleased = true;
        GameObject newInt = Instantiate(intruder, leftLocation, transform.rotation);
        spawnIntruder(newInt);


    }

    public void spawnOneRight()
    {
        intruderReleased = true;
        GameObject newInt = Instantiate(intruder, rightLocation, transform.rotation);
        spawnIntruder(newInt);
    }

    public void spawnFiveLeft()
    {
        intruderReleased = true;
        GameObject newInt = Instantiate(fiveIntruder, leftLocation, transform.rotation);
        spawnIntruder(newInt);
    }

    public void spawnFiveRight()
    {
        intruderReleased = true;
        GameObject newInt = Instantiate(fiveIntruder, rightLocation, transform.rotation);
        spawnIntruder(newInt);
    }

    public void spawnRandomLeft()
    {
        if (Random.Range(0.0f, 1.0f) <= intruderRate)
        {
            if (Random.Range(0.0f, 1.0f) < 0.5)
            {
                spawnFiveLeft();
            }
            else
            {
                spawnOneLeft();
            }
        }
    }

    public void spawnRandomRight()
    {
        if (Random.Range(0.0f, 1.0f) <= intruderRate)
        {
            if (Random.Range(0.0f, 1.0f) < 0.5)
            {
                spawnFiveRight();
            }
            else
            {
                spawnOneRight();
            }
        }
    }


}
