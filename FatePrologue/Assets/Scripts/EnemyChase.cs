using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    // initiallise variables
    public float forceStrength;
    private Transform target;

    private Rigidbody2D ourRigidbody;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        ourRigidbody = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        // this code checks to see if the player character is within range to chase
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        // this code enstructs the enemy to follow the player
        Vector2 direction = ((Vector2)target.position - (Vector2)transform.position).normalized;

        ourRigidbody.AddForce(direction * forceStrength);
    }
}
