using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonUI : MonoBehaviour
{
    [SerializeField] private string RestartLevel = "Pong";
    public void RestartButton()
    {
        SceneManager.LoadScene(RestartLevel);
    }
}
