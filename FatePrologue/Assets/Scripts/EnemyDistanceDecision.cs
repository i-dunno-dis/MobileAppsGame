using UnityEngine;

public class EnemyDistanceDecision : MonoBehaviour
{

    public float forceStrength;
    private Transform target;
    public float distanceForDecision;

    private EnemyPatrol patrolBehaviour;
    private EnemyChase chaseBehaviour;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        patrolBehaviour = GetComponent<EnemyPatrol>();
        chaseBehaviour = GetComponent<EnemyChase>();

        chaseBehaviour.enabled = false;
    }
    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    // Update is called once per frame
    void Update()
    {
        float distance = ((Vector2)target.position - (Vector2)transform.position).magnitude;

        if (distance <= distanceForDecision)
        {
            patrolBehaviour.enabled = false;
            chaseBehaviour.enabled = true;
        }
        else
        {
            patrolBehaviour.enabled = true;
            chaseBehaviour.enabled = false;
        }
    }
}
