using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinSceneChange : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnCollisionEnter2D(Collision2D collision)
    {
        // this ensures that the player colliding with the trigger object is tracked
        if (collision.gameObject.tag == ("Trigger"))
        {
            // this changes the scene to the win scene once the player collided with the trigger object
            SceneManager.LoadScene(3);
        }
    }
}
