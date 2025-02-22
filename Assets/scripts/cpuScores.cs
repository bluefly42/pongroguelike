using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    private void onCollisionGoal(Collider other){
        if (other.CompareTag("ball"))
        {
            cpuGoals += 1;
            Debug.Log("goal");
        }
    }
}
