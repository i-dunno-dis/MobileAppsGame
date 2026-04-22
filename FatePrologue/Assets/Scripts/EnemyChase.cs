using UnityEngine;

public class EnemyChase : MonoBehaviour
{

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
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = ((Vector2)target.position - (Vector2)transform.position).normalized;

        ourRigidbody.AddForce(direction * forceStrength);
    }
}
