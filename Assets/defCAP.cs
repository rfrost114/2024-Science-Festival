using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defCAP : MonoBehaviour
{
    public Rigidbody2D defender;
    public float defenderVelocity = 8;

    // 0 = left 1 = right
    private bool direction;

    public GameObject L1;
    public GameObject L2;
    public GameObject L3;

    public GameObject R1;
    public GameObject R2;
    public GameObject R3;

    public ScoreScript score;

    IEnumerator WaitAtLocation()
    {
        Vector2 defenderPosition = defender.position;


        if ((int)defenderPosition.x == -3)
        {
            direction = false;
            defenderPosition = defender.position;
            defender.velocity = Vector2.zero;
            defender.transform.position = new Vector3(-3f, 0.58f);
            yield return new WaitForSecondsRealtime(2.2f);

            if (leftComparison())
            {
                Debug.Log("problematic comparison Left " + defender.position.x);
                defender.velocity = Vector2.right * defenderVelocity;
            }


            // Do some comparison here
        }
        else if ((int)defenderPosition.x == 3)
        {
            direction = true;
            defender.velocity = Vector2.zero;
            defender.transform.position = new Vector3(3f, 0.58f);
            yield return new WaitForSecondsRealtime(2.2f);

            if (rightComparison())
            {
                Debug.Log("problematic comparison Right" + defenderPosition.x);
                defender.velocity = Vector2.left * defenderVelocity;
            }

        }

        
    }

    private bool leftComparison()
    {
        int same1 = L1.GetComponent<LeftColliderScript>().IntruderCount;
        int same2 = L2.GetComponent<LeftColliderScript>().IntruderCount;
        int same3 = L3.GetComponent<LeftColliderScript>().IntruderCount;
        int op2 = R2.GetComponent<LeftColliderScript>().IntruderCount;

        if (op2 > (same1 + same2 + same3))
        {
            return true;
        }
        return false;
    }

    private bool rightComparison()
    {
        int same1 = R1.GetComponent<LeftColliderScript>().IntruderCount;
        int same2 = R2.GetComponent<LeftColliderScript>().IntruderCount;
        int same3 = R3.GetComponent<LeftColliderScript>().IntruderCount;
        int op2 = L2.GetComponent<LeftColliderScript>().IntruderCount;

        if (op2 > (same1 + same2 + same3))
        {
            return true;
        }
        return false;
    }

    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreScript>();
        defender.velocity = Vector2.left * defenderVelocity;
 
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 defenderPosition = defender.position;
        //if ((int)defenderPosition.x == -3 || (int)defenderPosition.x == 3)
        //{
        //    defender.velocity = Vector2.zero;
            
        //}
        StartCoroutine(WaitAtLocation());


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

        defender.velocity = Vector2.zero;

        //if we were moving right
        //TODO: change this to prevent movement while sitting
        if (direction)
        {
            defender.velocity = Vector2.zero;
            defender.transform.position = new Vector3(3f, 0.58f);
        }
        else
        {
            defender.velocity = Vector2.zero;
            defender.transform.position = new Vector3(-3f, 0.58f);
        }
    }
}
