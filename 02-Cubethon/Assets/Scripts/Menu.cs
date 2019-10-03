using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame()
    {
    	// load next scene in build settings
    	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
