using JetBrains.Annotations;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 10.0f;
    [SerializeField] protected Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();

    }
}
