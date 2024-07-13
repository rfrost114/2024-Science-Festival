using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeftColliderScript : MonoBehaviour
{

    public int IntruderCount = 0;
    public Text text;

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
            text.text = IntruderCount.ToString();
        }
        else if (collision.gameObject.layer == 8)
        {
            IntruderCount += 5;
            text.text = IntruderCount.ToString();
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            IntruderCount -= 1;
            text.text = IntruderCount.ToString();
        }
        else if (collision.gameObject.layer == 8)
        {
            IntruderCount -= 5;
            text.text = IntruderCount.ToString();
        }
    }

}
