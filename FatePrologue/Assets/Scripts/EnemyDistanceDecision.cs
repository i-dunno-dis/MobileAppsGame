using UnityEngine;

public class EnemyDistanceDecision : MonoBehaviour
{
    //initialise variables
    public float forceStrength;
    private Transform target;
    public float distanceForDecision;

    private EnemyPatrol patrolBehaviour;
    private EnemyChase chaseBehaviour;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        //this fetches behaviours from the enemy patrol and enemy chase scripts
        patrolBehaviour = GetComponent<EnemyPatrol>();
        chaseBehaviour = GetComponent<EnemyChase>();
        //this sets the chse behaviour as false
        chaseBehaviour.enabled = false;
    }
    //this activaley searches for the player
    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    // Update is called once per frame
    void Update()
    {
        //this sets the distance needed for the enemy to decide if the player is close enough.
        float distance = ((Vector2)target.position - (Vector2)transform.position).magnitude;

        //this checks if the player is close enough to the enemy to enable the chase
        if (distance <= distanceForDecision)
        {
            //this enables the chase if the player is close
            patrolBehaviour.enabled = false;
            chaseBehaviour.enabled = true;
        }
        else
        {
            //this keeps it disabled if the player is not close
            patrolBehaviour.enabled = true;
            chaseBehaviour.enabled = false;
        }
    }
}
