using UnityEngine;

public class Player_Paddle : Paddle
{
    public Vector2 direction { get; private set; }

    // This function updates each frame
    private void Update()
    {
        // Take users input from keyboard and move paddle accordingly
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
            this.direction = Vector2.up;
        } else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {
            this.direction = Vector2.down;
        } else {
            this.direction = Vector2.zero;
        }
    }

    private void FixedUpdate()
    {
        // Apply force to paddle based on speed and direction
        if (this.direction.sqrMagnitude != 0) {
            this.GetComponent<Rigidbody2D>().AddForce(this.direction * this.speed);
        }
    }

}