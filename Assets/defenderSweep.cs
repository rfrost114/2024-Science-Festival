using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defenderSweep : MonoBehaviour
{
    public Rigidbody2D defender;

    // the correct velocity for intercept is anything over 13.5
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
    }

    // Update is called once per frame
    void Update()
    {
        sweepingMotion();

    }

    private void sweepingMotion()
    {
        Vector2 defenderPosition = defender.position;



        // direction change
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
        else
        {
            // if we aren't changing directions, then we should update the speed anyway in case it's changed
            if (direction)
            {
                defender.velocity = Vector2.right * defenderVelocity;
            }
            else
            {
                defender.velocity = Vector2.left * defenderVelocity;
            }
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
