using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]
public class PlayerMovement: MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody2D physicsBody = null;
    public Collider2D groundSensor = null;
    public LayerMask groundLayer = 0;

    private void Awake()
    {
        physicsBody = GetComponent<Rigidbody2D>();
    }

    public void MoveLeft()
    {
        physicsBody.linearVelocityX = -speed;
    }
    public void MoveRight()
    {
        physicsBody.linearVelocityX = speed;
    }
    public float jumpSpeed = 5;
    public void Jump()
    {
        if (groundSensor.IsTouchingLayers(groundLayer))
        {
            Vector2 newVelocity = physicsBody.linearVelocity;
            newVelocity.y = jumpSpeed;
            physicsBody.linearVelocity = newVelocity;
        }
    }
}
