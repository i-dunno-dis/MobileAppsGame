using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public void Kill()
    {
        Destroy(gameObject);
    }
    public int startingHealth = 10;

    private int currentHealth;

    private void Awake()
    {
        currentHealth = startingHealth;
    }

    public void ChangeHealth(int ChangeAmount = 2)
    {
        

        currentHealth = currentHealth + ChangeAmount;
        currentHealth = Mathf.Clamp(currentHealth, 0, startingHealth);
    }

    private void Update()
    {
        if (currentHealth <= 0)
        {
            Kill();
            
        }
    }
}
    
