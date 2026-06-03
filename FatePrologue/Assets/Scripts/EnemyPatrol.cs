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
        float distance = (patrolPoints[currentPoint] - (Vector2)transform.position).magnitude;

        if (distance <= stopDistance)
        {
            currentPoint = currentPoint + 1;

            if (currentPoint >= patrolPoints.Length)
            {
                currentPoint = 0;
            }
        }

        Vector2 direction = (patrolPoints[currentPoint] - (Vector2)transform.position).normalized;
        ourRigidbody.linearVelocity = direction * forceStrength;

        if (ourRigidbody.linearVelocityX < 0f)
        {
            mySpriteRenderer.flipX = true;
        }

        else
        {
            mySpriteRenderer.flipX = false;
        }



        //ourRigidbody.AddForce(direction * forceStrength);
    }
}
