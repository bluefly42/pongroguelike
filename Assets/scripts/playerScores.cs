using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScores : MonoBehaviour
{ 
    private Serve serveScript;
    private Victory victoryScript;
    private GameManager gameScript;
    // Start is called before the first frame update
    void Start()
    {
        serveScript = GameObject.Find("serve object").GetComponent<Serve>();//link to the script Serve.cs to use later
        gameScript = GameObject.Find("game manager object").GetComponent<GameManager>();
    }

    //if the goal box is hit by the ball
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerGoal(collision.collider);
    }

    private void PlayerGoal(Collider2D collider)
    {

        if (collider.CompareTag("ball")) //check it is colliding with a ball
        {
            collider.gameObject.SetActive(false); //deactivate the ball until it is moved back to the centre
            gameScript.playerScores();//iterate player's goals
            StartCoroutine(DelayedServe(1f, collider)); //serve after a second
        }
    }

    IEnumerator DelayedServe(float delayTime, Collider2D ball) //coroutine to delay the serve
    {
        //Wait for the specified delay time before continuing.
        yield return new WaitForSeconds(delayTime);
        serveScript.StartServe("Computer");//serve to the cpu because they conceded
    }
}

