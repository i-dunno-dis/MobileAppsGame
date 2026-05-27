using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    //this code allows for the scene to change
    public void ChangeToScene(string targetSceneName)
    {
        SceneManager.LoadScene(targetSceneName);
    }
}