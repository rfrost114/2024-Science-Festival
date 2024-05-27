using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftColliderScript : MonoBehaviour
{

    public int IntruderCount = 0;

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
        if (collision.gameObject.layer == 7)
        {
            IntruderCount += 1;
        }
        else if (collision.gameObject.layer == 8)
        {
            IntruderCount += 5;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            IntruderCount -= 1;
        }
        else if (collision.gameObject.layer == 8)
        {
            IntruderCount -= 5;
        }
    }

}
