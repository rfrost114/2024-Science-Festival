using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomIntruderSpawnScript : MonoBehaviour
{
    public GameObject intruder;
    public GameObject fiveIntruder;
    public GameObject reset;
    private Vector3 leftLocation = new Vector3(-8f, 0.5f);
    private Vector3 rightLocation = new Vector3(8f, 0.5f);
    public bool intruderReleased = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (timer < spawnRate)
        //{
        //    timer += Time.deltaTime;
        //}
        //else
        //{
        //    spawnRandomIntruder();
        //    timer = 0;
        //}

    }


    private void spawnRandomIntruder()
    {
        
        if (Random.Range(0f,1f) > .5)
        {
            Instantiate(intruder, leftLocation, transform.rotation);
        }
        else
        {
            Instantiate(intruder, rightLocation, transform.rotation);
        }
    }

    public void spawnOneLeft()
    {
        intruderReleased = true;
        GameObject newInt = Instantiate(intruder, leftLocation, transform.rotation);
        if (reset.GetComponent<resetManagerScript>().speedToggle)
        {
            newInt.GetComponent<IntruderScript>().SetVelocity(2.2f);
        }
        else
        {
            newInt.GetComponent<IntruderScript>().SetVelocity(1.47f);
        }
        
        //Instantiate(intruder, leftLocation, transform.rotation);
    }

    public void spawnOneRight()
    {
        intruderReleased = true;
        GameObject newInt = Instantiate(intruder, rightLocation, transform.rotation);
        if (reset.GetComponent<resetManagerScript>().speedToggle)
        {
            newInt.GetComponent<IntruderScript>().SetVelocity(2.2f);
        }
        else
        {
            newInt.GetComponent<IntruderScript>().SetVelocity(1.47f);
        }
    }

    public void spawnFiveLeft()
    {
        intruderReleased = true;
        GameObject newInt = Instantiate(fiveIntruder, leftLocation, transform.rotation);
        if (reset.GetComponent<resetManagerScript>().speedToggle)
        {
            newInt.GetComponent<IntruderScript>().SetVelocity(2.2f);
        }
        else
        {
            newInt.GetComponent<IntruderScript>().SetVelocity(1.47f);
        }
    }

    public void spawnFiveRight()
    {
        intruderReleased = true;
        GameObject newInt = Instantiate(fiveIntruder, rightLocation, transform.rotation);
        if (reset.GetComponent<resetManagerScript>().speedToggle)
        {
            newInt.GetComponent<IntruderScript>().SetVelocity(2.2f);
        }
        else
        {
            newInt.GetComponent<IntruderScript>().SetVelocity(1.47f);
        }
    }


}
