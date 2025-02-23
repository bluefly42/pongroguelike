using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Marketplace : MonoBehaviour
{
    [SerializeField] public Button exitButton;
    private void Awake()
    {
        exitButton = GameObject.Find("exitbutton").GetComponent<Button>();
        exitButton.interactable = true;
        exitButton.onClick.AddListener(ExitButton);
    }
    public void ExitButton()
    {
        exitButton.interactable = false;
        StartCoroutine(WaitingSceneChange(2.0f, "Pong"));
    }
    IEnumerator WaitingSceneChange(float delayTime, string scene) //coroutine to delay the serve
    {
        //Wait for the specified delay time before continuing.
        Debug.Log("changing scene");
        yield return new WaitForSeconds(delayTime);
        SceneManager.LoadScene(scene);//serve to the cpu because they conceded
    }
}