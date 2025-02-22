using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball;
    private void Awake()
    {
        ball = GameObject.FindWithTag("ball").GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (GameObject.FindWithTag("ball") != null) //if there is a ball then set focus to the right ball
        {
            ball = GameObject.FindWithTag("ball").GetComponent<Rigidbody2D>();
        }

    }
    private void FixedUpdate()
    {
        if (GameObject.FindWithTag("ball") != null)
        {
            if (this.ball.velocity.x > 0.0f)
            {
                if (this.ball.position.y > this.transform.position.y)
                {
                    _rigidbody.AddForce(Vector2.up * this.speed);
                }
                else if (this.ball.position.y < this.transform.position.y)
                    _rigidbody.AddForce(Vector2.down * this.speed);
            }
            else
            {
                if (this.transform.position.y > 0.0f)
                {
                    _rigidbody.AddForce(Vector2.down * this.speed);
                }
                else if (this.transform.position.y < 0.0f)
                {
                    _rigidbody.AddForce(Vector2.up * this.speed);
                }
            }
        }
    }
}
