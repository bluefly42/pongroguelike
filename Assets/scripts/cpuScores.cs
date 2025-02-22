using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//push comment
public class cpuScores : MonoBehaviour
{
    [SerializeField] int cpuGoals;
    // Start is called before the first frame update
    void Start()
    {
        cpuGoals = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    //if the goal box is hit by the ball
    private void OnCollisionEnter2D(Collision2D collision)
    {
        CpuGoal(collision.collider);
    }

    private void CpuGoal(Collider2D collider)
    {
        if (collider.CompareTag("ball"))
        {
            Destroy(collider.gameObject);
            cpuGoals += 1;
            new WaitForSeconds(1);

        }
    }
}
