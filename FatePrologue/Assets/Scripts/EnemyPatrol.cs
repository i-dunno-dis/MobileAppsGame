using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    //this initailises each variable before they can be used
    public float forceStrength;
    public Vector2[] patrolPoints;
    public float stopDistance;
    private Rigidbody2D ourRigidbody;
    private int currentPoint = 0;
    public float speed = 1f;
    private SpriteRenderer mySpriteRenderer = null;

    private void Awake()
    {
        //this fetches specific attributes from within the pogram so they can be used here
        ourRigidbody = GetComponent<Rigidbody2D>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //this checks where the enemy is in accodance to the current patol point
        float distance = (patrolPoints[currentPoint] - (Vector2)transform.position).magnitude;

        //this checks if the currnt patrol point has been reached
        if (distance <= stopDistance)
        {
            currentPoint = currentPoint + 1;
            //this checks if the next patrol point was reached
            if (currentPoint >= patrolPoints.Length)
            {
                //this sets the current patrol point to 0
                currentPoint = 0;
            }
        }
        //this sets the direction the enemy moves according to its current location 
        Vector2 direction = (patrolPoints[currentPoint] - (Vector2)transform.position).normalized;
        //this sets the speed of the enemy
        ourRigidbody.linearVelocity = direction * forceStrength;

        //this flips the sprite to go towards the negative x
        if (ourRigidbody.linearVelocityX < 0f)
        {
            mySpriteRenderer.flipX = true;
        }
        //this flips the sprite to go towards the postive x
        else
        {
            mySpriteRenderer.flipX = false;
        }



        
    }
}
