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
        int iconHealth = 0;
        foreach (GameObject icon in healthIcons)
        {

            iconHealth = iconHealth + 1;


            if (player.GetHealth() >= iconHealth)
            {
                icon.SetActive(true);
            }
            else
            {
                icon.SetActive(false);
            }
        }

    }
}
