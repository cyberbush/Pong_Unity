using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D _rigidbody;

    public float speed = 150.0f;  

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        ResetPosition();
        AddStartingForce();
    }

    public void ResetPosition()
    {
        _rigidbody.position = Vector3.zero;
        _rigidbody.velocity = Vector3.zero;
    }


    // Apply force to ball at start of game
    public void AddStartingForce()
    {
        // Determines the direction the ball starts randomly
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        // Determines the angle the ball starts at randomly        
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : 
                                        Random.Range(0.5f, 1.0f);
        
        Vector2 direction = new Vector2(x, y);
        _rigidbody.AddForce(direction * this.speed);
    }

    // Lets other scripts add force to the ball's rigidbody
    public void AddForce(Vector2 force)
    {
        _rigidbody.AddForce(force);
    }


}
