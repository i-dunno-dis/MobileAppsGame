using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinSceneChange : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("Trigger"))
        {
            SceneManager.LoadScene(3);
        }
    }
}
