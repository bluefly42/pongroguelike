using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void onCollisionGoal(Collider other){
        if (other.CompareTag("ball"))
        {
            Debug.Log("goal");
        }
    }
}
