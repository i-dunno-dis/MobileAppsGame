using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float forceStrength;
    public Vector2 direction;
    private Rigidbody2D ourRigidbody;

    private void Awake()
    {
        ourRigidbody = GetComponent<Rigidbody2D>();
        direction=direction.normalized;
    }
    // Update is called once per frame
    void Update()
    {
        ourRigidbody.AddForce(direction*forceStrength);
    }
}
