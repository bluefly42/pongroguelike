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

    private void onCollisionGoal(Collider other){
        if (other.CompareTag("ball"))
        {
            Destroy(other);
            playerGoals += 1;
            Debug.Log("Player goal.");
            new WaitForSeconds(1);
            
        }
    }
}
