using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    [SerializeField] int playerScore;
    [SerializeField] int cpuScore;
    private Victory victoryScript; 
    private Lose loseScript;
    [SerializeField] private TextMeshProUGUI playerScoreText;
    [SerializeField] private TextMeshProUGUI cpuScoreText;
    [SerializeField] public float ballSpeed;
    // Start is called before the first frame update
    void Start()
    {
        playerScore = 0;
        cpuScore = 0;
        victoryScript = GameObject.Find("victory object").GetComponent<Victory>();
        loseScript = GameObject.Find("loss object").GetComponent<Lose>();
        playerScoreText.text = playerScore.ToString();
        cpuScoreText.text = cpuScore.ToString();
        ballSpeed = 200f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playerScores()
    {
        playerScore++;
        playerScoreText.text = playerScore.ToString();
        if (playerScore == 7)
        {
            victoryScript.NextVictoryScreen();
        }
    }
    public void cpuScores()
    {
        cpuScore++;
        cpuScoreText.text = cpuScore.ToString();
        if (cpuScore == 7)
        {
            loseScript.LoseScreen();
        }
    }
}
