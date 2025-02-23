using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] public float speed;
    [SerializeField] private Rigidbody2D ball; //moved serving over to another script
    private GameManager gameScript;
    private Rigidbody2D _rigidbody;
    private void Start()
    {
        speed = gameScript.ballSpeed;
    }
    private void Awake()
    {
        ball = GameObject.FindWithTag("ball").GetComponent<Rigidbody2D>(); //assign the ball so the program doesn't freak
        gameScript = GameObject.Find("game manager object").GetComponent<GameManager>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        speed = gameScript.ballSpeed;
    }

    public void AddStartingForce(System.String tag) //AddStartingForce takes the tag of who conceded so it knows who to serve to
    {
        ball = GameObject.FindWithTag("ball").GetComponent<Rigidbody2D>();
        if (tag == "Player") //if player then serve towards the player
        {
            float x = Random.Range(-1.0f,-0.5f);
            float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);

            Vector2 direction = new Vector2(x, y);
            ball.AddForce(direction * this.speed);
        }
        if (tag == "Computer") //if player then serve towards the Computer
        {
            float x = Random.Range(0.5f, 1.0f);
            float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);

            Vector2 direction = new Vector2(x, y);
            ball.AddForce(direction * this.speed);
        }
    }
    public void UpdateBallSpeed()
    {
        speed = gameScript.ballSpeed;
    }

    public void AddForce(Vector2 force)
    {
        ball = GameObject.FindWithTag("ball").GetComponent<Rigidbody2D>();
        ball.AddForce(force);
    }
}
