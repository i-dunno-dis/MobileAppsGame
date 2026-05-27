using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]
public class PlayerMovement: MonoBehaviour
{
    //initiallise variables
    public float speed = 1f;
    private Rigidbody2D physicsBody = null;
    public Collider2D groundSensor = null;
    public LayerMask groundLayer = 0;
    private Animator myAnimator = null;

    private void Awake()
    {
        //get components for movement and animation
        physicsBody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
    }

    public void MoveLeft()
    {
        //set calculation for negative speed
        physicsBody.linearVelocityX = -speed;
    }
    public void MoveRight()
    {
        //set calculation for speed
        physicsBody.linearVelocityX = speed;
    }

    private void Update()
    {
        //convert negative speed to positive speed for animation
        myAnimator.SetFloat("speed", Mathf.Abs(physicsBody.linearVelocityX));
    }

    public float jumpSpeed = 5;
    public void Jump()
    {
        //this tracks to see if the player is touching the ground
        if (groundSensor.IsTouchingLayers(groundLayer))
        {
            //if the player is touching the ground the player is able to jump
            Vector2 newVelocity = physicsBody.linearVelocity;
            newVelocity.y = jumpSpeed;
            physicsBody.linearVelocity = newVelocity;
        }
    }
}
