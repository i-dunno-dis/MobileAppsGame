using UnityEngine;

public class HealthDisplay : MonoBehaviour
{

    public GameObject[] healthIcons;

    PlayerHealth player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = FindAnyObjectByType<PlayerHealth>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //this sets the health of the icons
        int iconHealth = 0;
        //this ensures each icon has the same health value
        foreach (GameObject icon in healthIcons)
        {

            iconHealth = iconHealth + 1;

            //this fetches the player's health and checks if it is less than what is currently stored within the script
            if (player.GetHealth() >= iconHealth)
            {
                //if its greater or equal the icon stays the same
                icon.SetActive(true);
            }
            else
            {
                //otherwise the one or more icons blink out
                icon.SetActive(false);
            }
        }

    }
}
