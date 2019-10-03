using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	// make sure game is ended only once
	bool gameHasEnded = false;

    // delay time (sec) during game restart
	public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        Debug.Log("LEVEL WON");
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
    	if(gameHasEnded == false)
    	{
    		gameHasEnded = true;
    		Debug.Log("GAME OVER");
    		Invoke("Restart", restartDelay); // Restart();
    	}
    }

    void Restart()
    {
    	SceneManager.LoadScene(SceneManager.GetActiveScene().name); // or "Level01"
    }
}
