using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncySurface : MonoBehaviour
{

    private GameManager gameScript;
    private void Start()
    {
        gameScript = GameObject.Find("game manager object").GetComponent<GameManager>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameScript.bounce(collision);
    }
}
