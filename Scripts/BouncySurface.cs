using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    public float bounceStrength;

    // Function used to track collisions
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        // Apply force to ball in opposite direction of surface
        if (ball != null) {
            Vector2 normal = collision.GetContact(0).normal;
            ball.AddForce(-normal * this.bounceStrength);
        }
    }
}
