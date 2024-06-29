using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defenderSweep : MonoBehaviour
{
    public Rigidbody2D defender;
    private float defenderVelocity = 8;

    // 0 = left 1 = right
    private bool direction;

    public ScoreScript score;

    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreScript>();
        defender.velocity = Vector2.left * defenderVelocity;
        direction = false;
        //defender.transform.position = new Vector3(3, 0.58f);
    }

    // Update is called once per frame
    void Update()
    {
        sweepingMotion();
        //defender.velocity = Vector2.zero;
        //defender.transform.position = new Vector3(3, 0.58f);

    }

    private void sweepingMotion()
    {
        Vector2 defenderPosition = defender.position;
        
        if ((int)defenderPosition.x == -8)
        {

            defender.velocity = Vector2.right * defenderVelocity;
            direction = true;
        }
        else if ((int)defenderPosition.x == 8)
        {
            defender.velocity = Vector2.left * defenderVelocity;
            direction = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            score.markCaptureOne();
        }
        else if (collision.gameObject.layer == 8)
        {
            score.markCaptureFive();
        }
        Destroy(collision.gameObject);
        //if we were moving right

        if (direction)
        {
            defender.velocity = Vector2.right * defenderVelocity;
            direction = true;
        }
        else
        {
            defender.velocity = Vector2.left * defenderVelocity;
            direction = false;
        }
    }

    public bool getDirection()
    {
        return direction;
    }

    public float getVelocity()
    {
        return defenderVelocity;
    }

    public void setVelocity(float newVelocity)
    {
        defenderVelocity = newVelocity;
    } 


}
