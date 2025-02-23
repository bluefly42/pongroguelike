using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MarketplacePurchasing : MonoBehaviour
{
    [SerializeField] public Button button;
    [SerializeField] public float value;
    private void Awake()
    {
        button = this.GetComponent<Button>();
        button.onClick.AddListener(Button);
        Debug.Log("Hello");
    }
    public void Button()
    {
        Debug.Log("button");
    }

}
