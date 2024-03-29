using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    public float bounceStrength;

    // Unity function on collisions
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        // try to get reference to ball. If it is null, something other than ball got collided.
        if (ball != null)
        {
            // the normal is the angle at contact point (vector pointing away from surface)
            Vector2 normal = collision.GetContact(0).normal;
            ball.AddForce(-normal * this.bounceStrength);
        }
    }
}
