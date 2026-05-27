using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{

    public float forceStrength;
    public Vector2[] patrolPoints;
    public float stopDistance;
    private Rigidbody2D ourRigidbody;
    private int currentPoint = 0;
    private Animator myAnimator = null;
    public float speed = 1f;
    private SpriteRenderer mySpriteRenderer = null;

    private void Awake()
    {
        ourRigidbody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void LeftSquirm()
    {
        ourRigidbody.linearVelocityX = -speed;
    }
    public void RightSquirm()
    {
        ourRigidbody.linearVelocityX = speed;
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
