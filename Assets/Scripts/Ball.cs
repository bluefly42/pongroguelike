using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 250.0f;
    [SerializeField] private Rigidbody2D ball;
    private Rigidbody2D ogball;//save a copy of the first ball

    private void Awake()
    {
       ogball = GameObject.FindGameObjectWithTag("ball").GetComponent<Rigidbody2D>(); //make sure you find the ball and not the paddles
       ball = GameObject.FindGameObjectWithTag("ball").GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        Serve("Player"); //let the player get the first serve
    }

    public void Serve(System.String tag) //takes Player or computer to pass to AddStartingForce
    {
        Debug.Log("hello");
        if (GameObject.FindWithTag("ball") is null)//if ball does not exist
        {
            Debug.Log("hello again");
            Instantiate(ogball); //make a new copy of the first ball
        }
        AddStartingForce(tag); //move the ball in the right direction
    }
    private void AddStartingForce(System.String tag) //AddStartingForce takes the tag of who conceded so it knows who to serve to
    {
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

}
