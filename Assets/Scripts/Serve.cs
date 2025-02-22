using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Serve : MonoBehaviour
{
    //probably not the best way to do this but oh my god it took so long please don't touch it
    [SerializeField]private Rigidbody2D serveball;

    // Start is called before the first frame update
    void Start()
    {
        serveball = GameObject.FindGameObjectWithTag("ball").GetComponent<Rigidbody2D>();
        StartServe("Player");
    }
    public void StartServe(System.String tag)
    {
        serveball.transform.position = new Vector2(0, 0);
        serveball.gameObject.SetActive(true);
        serveball.GetComponent<Ball>().AddStartingForce(tag);
    }
}

