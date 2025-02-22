using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScores : MonoBehaviour
{
    [SerializeField] int playerGoals;
    // Start is called before the first frame update
    void Start()
    {
        playerGoals = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    //if the goal box is hit by the ball
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerGoal(collision.collider);
    }

    private void PlayerGoal(Collider2D collider)
    {
        if (collider.CompareTag("ball"))
        {
            Destroy(collider.gameObject);
            playerGoals += 1;
            new WaitForSeconds(1);

        }
    }
}
