using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntruderScript : MonoBehaviour
{

    public Rigidbody2D intruder;
    private float intruderVelocity = 1.47f;
    public const int INTRUDERVALUE = 1;

    // Start is called before the first frame update
    void Start()
    {
        Vector2 intruderStartingLocation = intruder.position;
        
        if ((int)intruderStartingLocation.x == -8)
        {
            intruder.velocity = Vector2.right * intruderVelocity;
        }
        else if ((int)intruderStartingLocation.x == 8)
        {
            intruder.velocity = Vector2.left * intruderVelocity;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // if the intruder reaches the right side of the perimeter
        if ((int)intruder.position.x == -1 || (int)intruder.position.x == 1)
        {
            Destroy(gameObject);
        }

        // if intruder leaves the env
        if (intruder.position.x > 8.2 || intruder.position.x < -8.2)
        {
            Destroy(gameObject);
        }
    }

    public void SetVelocity(float velocity)
    {
        intruderVelocity = velocity;
    }
}
