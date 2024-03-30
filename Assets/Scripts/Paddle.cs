using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 10.0f;
    protected Rigidbody2D _rigidBody;

    // Calls automatically on script. Gets called only one time in the entire lifecycle. 
    // Any initialization 
    private void Awake()
    {
        // Unity searches for any component in this script and looks for that component.
        // If there is, it gets returned and we can assign it. Allows us to establish a
        // reference to the rigidbody.
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    public void ResetPosition()
    {
        _rigidBody.position = new Vector2(_rigidBody.position.x, 0.0f);
        _rigidBody.velocity = Vector2.zero;
    }
}
