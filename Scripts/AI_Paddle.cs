using UnityEngine;

public class AI_Paddle : Paddle
{
    public Rigidbody2D ball;

    private void FixedUpdate()
    {
        if (this.ball.velocity.x > 0.0f){ // check if ball moving towards Ai
            // If ball is above Ai paddle move Ai paddle up
            if (this.ball.position.y > this.transform.position.y){
                _rigidbody.AddForce(Vector2.up * this.speed);
            }
            // If ball is below Ai paddle move Ai paddle down
            else if (this.ball.position.y < this.transform.position.y) {
                _rigidbody.AddForce(Vector2.down * this.speed);
            }
        }
        else { // Make Ai idle in center if ball is moving away
            if (this.transform.position.y > 0.0f){
                _rigidbody.AddForce(Vector2.down * this.speed);
            }
            else if (this.transform.position.y < 0.0f){
                _rigidbody.AddForce(Vector2.up *this.speed);
            }
        }
    }
}
