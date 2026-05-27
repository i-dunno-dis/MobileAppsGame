using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    //initialise variables
    public int startingHealth = 10;

    private int currentHealth;

    private void Awake()
    {
        //this sets the current health to the starting health
        currentHealth = startingHealth;
    }

    public void ChangeHealth(int ChangeAmount = 2)
    {
        
        //this changes the health by the change amount
        currentHealth = currentHealth + ChangeAmount;
        currentHealth = Mathf.Clamp(currentHealth, 0, startingHealth);
    }

    private void Update()
    {
        //this checks if health is below zero
        if (currentHealth <= 0)
        {
            //if health is below zero it loads the death screen
            SceneManager.LoadScene(2);
            
        }
    }
    //this fetches the current health for the health display script
    public int GetHealth()
    {
        //this returns the current health to the health display script
        return currentHealth;
    }
}
    
