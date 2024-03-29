using UnityEngine;

public class ComputerPaddle : Paddle
{
    // in editor, drag the ball to the rigidbody
    public Rigidbody2D ball;

    // track position of the ball
    private void FixedUpdate()
    {
        // ball moving right, towards computer
        if (this.ball.velocity.x > 0.0f)
        {
            if (this.ball.position.y > this.transform.position.y)
            {
                _rigidBody.AddForce(Vector2.up * this.speed);
            } else if (this.ball.position.y < this.transform.position.y)
            {
                _rigidBody.AddForce(Vector2.down * this.speed);
            }
        } 
        else
        {
            // greater than 0 means that its above the center line
            if (this.transform.position.y > 0.0f)
            {
                _rigidBody.AddForce(Vector2.down * this.speed);
            } else
            {
                _rigidBody.AddForce(Vector2.up * this.speed);
            }
        }
    }
}
