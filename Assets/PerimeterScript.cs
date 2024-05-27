using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerimeterScript : MonoBehaviour
{

    public ScoreScript score;
    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7) {

            score.markLossOne();
            Destroy(collision.gameObject);
            
        }
        else if (collision.gameObject.layer == 8)
        {
            score.markLossFive();
            Destroy(collision.gameObject);
        }
    }
}
