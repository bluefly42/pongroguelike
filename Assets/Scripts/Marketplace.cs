using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Marketplace : MonoBehaviour
{
    [SerializeField] public Button bronzeButton;
    [SerializeField] public Button silverButton;
    [SerializeField] public Button goldButton;

    private void Awake()
    {
        bronzeButton = GameObject.Find("Bronze Button").GetComponent<Button>();
        silverButton = GameObject.Find("Silver Button").GetComponent<Button>();
        goldButton = GameObject.Find("Gold Button").GetComponent<Button>();
        bronzeButton.onClick.AddListener(BronzeButton);
        silverButton.onClick.AddListener(SilverButton);
        goldButton.onClick.AddListener(GoldButton);
    }
    public void BronzeButton()
    {
        Debug.Log("bronze");
    }
    public void SilverButton()
    {
        Debug.Log("silver");
    }
    public void GoldButton()
    {
        Debug.Log("gold");
    }

}