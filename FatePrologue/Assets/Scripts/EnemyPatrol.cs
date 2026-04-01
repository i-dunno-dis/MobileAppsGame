using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public float forceStrength;
    public Vector2 patrolPoint;
    private Rigidbody2D ourRigidbody;

    private void Awake()
    {
        ourRigidbody = GetComponent<Rigidbody2D>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = patrolPoint - (Vector2)transform.position;
        ourRigidbody.AddForce(direction * forceStrength);
    }
}
