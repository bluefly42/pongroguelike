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
    [SerializeField] public float ballSpeed = 150f;
    [SerializeField] new AudioSource audio;
    //private float BounceBreak = 0.5f;  //Wait 0.5 seconds after we do something to do something again
    //private float BounceIncreaseTime;  //The next time we do something
    public float bounciness;


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
        ballSpeed = 150f;
        audio.Play(0);
        //BounceIncreaseTime = Time.time + BounceBreak;
        //bounciness = 4f;
        //Debug.Log(bounciness);
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (BounceIncreaseTime <= Time.time)
        //{
        //    bounciness = bounciness * 1.5f;
        //    BounceIncreaseTime = Time.time + BounceBreak;
        //    Debug.Log("bounce increase");
        //}

    }

    public void playerScores()
    {
        playerScore++;
        playerScoreText.text = playerScore.ToString();
        ballSpeed = 150f;
        //BounceIncreaseTime = Time.time + BounceBreak;
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
        ballSpeed = 150f;
        //BounceIncreaseTime = Time.time + BounceBreak;
        if (cpuScore == 7)
        {
            audio.Stop();
            loseScript.LoseScreen();
        }
    }


}
