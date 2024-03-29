using UnityEngine;

public class PlayerPaddle : Paddle
{
    // look for player input, then update paddle
    private Vector2 _direction;

    // Update gets called every frame the game is running.
    private void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            _direction = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            _direction = Vector2.down;
        }
        else
        {
            _direction = Vector2.zero;
        }
    }

    // FixedUpdate is called at a fixed time interval.
    // Usually associated with physics
    private void FixedUpdate()
    {
        if(_direction.sqrMagnitude != 0)
        {
            _rigidBody.AddForce(_direction * this.speed);
        }
    }

}
