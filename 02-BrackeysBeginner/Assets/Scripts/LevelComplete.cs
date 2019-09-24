using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel()
    {
    	// load next scene in build settings
    	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
