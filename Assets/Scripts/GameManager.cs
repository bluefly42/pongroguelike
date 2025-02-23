using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] int playerScore;
    [SerializeField] int cpuScore;
    private Victory victoryScript;
    private Lose loseScript;
    // Start is called before the first frame update
    void Start()
    {
        playerScore = 0;
        cpuScore = 0;
        victoryScript = GameObject.Find("victory object").GetComponent<Victory>();
        loseScript = GameObject.Find("lose object").GetComponent<Lose>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playerScores()
    {
        playerScore++;
        if (playerScore == 7)
        {
            victoryScript.NextVictoryScreen();
        }
    }
    public void cpuScores()
    {
        cpuScore++;
        if (cpuScore == 7)
        {
            loseScript.LoseScreen();
        }
    }
}
