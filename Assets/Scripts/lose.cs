using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{
    [SerializeField] private string lose = "GameOver";
    public void LoseScreen()
    {
        SceneManager.LoadScene(lose);
    }
}
