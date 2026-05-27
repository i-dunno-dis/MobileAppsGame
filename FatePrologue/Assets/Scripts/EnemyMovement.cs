using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    //this initiallises variables
    public float forceStrength;
    public Vector2 direction;
    private Rigidbody2D ourRigidbody;

    private void Awake()
    {
        //this gets the rigid body of the enemy
        ourRigidbody = GetComponent<Rigidbody2D>();
        //this sets the direction
        direction=direction.normalized;
    }
    // Update is called once per frame
    void Update()
    {
        //this sets the speed at which the enemy moves
        ourRigidbody.AddForce(direction*forceStrength);
    }
}
