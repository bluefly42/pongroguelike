using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Security.Cryptography;
public class GameManager : MonoBehaviour
{
    [SerializeField] int playerScore;
    [SerializeField] int cpuScore;
    private Victory victoryScript; 
    private Lose loseScript;
    [SerializeField] private TextMeshProUGUI playerScoreText;
    [SerializeField] private TextMeshProUGUI cpuScoreText;
    [SerializeField] public float ballSpeed = 200f;
    [SerializeField] new AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GameObject.Find("audio1").GetComponent<AudioSource>();
        audio.volume = 0.25f;
        audio.loop = true;
        audio.Play();
        playerScore = 0;
        cpuScore = 0;
        victoryScript = GameObject.Find("victory object").GetComponent<Victory>();
        loseScript = GameObject.Find("loss object").GetComponent<Lose>();
        playerScoreText.text = playerScore.ToString();
        cpuScoreText.text = cpuScore.ToString();
        ballSpeed = 200f;
        audio.Play(0);
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
            audio.Stop();
            victoryScript.NextVictoryScreen();
        }
    }
    public void cpuScores()
    {
        cpuScore++;
        cpuScoreText.text = cpuScore.ToString();
        if (cpuScore == 7)
        {
            audio.Stop();
            loseScript.LoseScreen();
        }
    }
}
