using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VictoryScreen : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        button.gameObject.SetActive(true);
// button.onClick.NextLevel();
    }

    // Update is called once per frame
    private void NextLevel() {
        button.gameObject.SetActive(false);
        SceneManager.LoadScene("Marketplace");
    }
}
