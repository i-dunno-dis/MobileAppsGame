using UnityEngine;

public class Hazard : MonoBehaviour
{
    //this sets the amount of damage done by the enemy
    public int hazardDamage = 2;
    //this ensures that damage is only taken on contact
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //this sets the collider
        Collider2D collider = collision.collider;
        //this fetches the current player health value
        PlayerHealth player = collider.GetComponent<PlayerHealth>();
        //this ensures that the player is not dead
        if (player != null )
        {
            //this decreases the player health by the amount of damage the enemy does
            player.ChangeHealth(-hazardDamage);
        }
    }
}
