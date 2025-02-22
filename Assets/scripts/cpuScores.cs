using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
//push comment
public class cpuScores : MonoBehaviour
{
    [SerializeField] int cpuGoals;
    private Serve serveScript;
    // Start is called before the first frame update
    void Start()
    {
        serveScript = GameObject.Find("serve object").GetComponent<Serve>(); //link to the script Serve.cs to use later
        cpuGoals = 0;
    }

    //if the goal box is hit by the ball
    private void OnCollisionEnter2D(Collision2D collision)
    {
        CpuGoal(collision.collider);
    }

    private void CpuGoal(Collider2D collider)
    {

        if (collider.CompareTag("ball")) //check it is colliding with a ball
        {
            collider.gameObject.SetActive(false); //deactivate the ball until it is moved back to the centre
            cpuGoals += 1;//iterate cpu's goals
            StartCoroutine(DelayedServe(1f, collider)); //serve after a second
        }
    }

    IEnumerator DelayedServe(float delayTime, Collider2D ball) //coroutine to delay the serve
    {
        Debug.Log("hello again");
        //Wait for the specified delay time before continuing.
        yield return new WaitForSeconds(delayTime);
        serveScript.StartServe("Player");//serve to the player because they conceded
    }
}


