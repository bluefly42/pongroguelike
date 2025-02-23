using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VictoryScreen : MonoBehaviour
{
    [SerializeField] public Button button;
    // Start is called before the first frame update
    private void Awake()
    {
        button = GameObject.Find("Button").GetComponent<Button>();
        button.gameObject.SetActive(true);
        button.onClick.AddListener(NextLevel);
    }

    private void NextLevel() {
        Debug.Log("hello");
        button.gameObject.SetActive(false);
        SceneManager.LoadScene("Marketplace");
    }
}
