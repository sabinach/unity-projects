using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
	//public Slider obstacleSlider;
	public Text numObstacleText;

	public void SetNumObstacles(int numObstacles)
	{
		Debug.Log(numObstacles);
		numObstacleText.text = numObstacles.ToString();
	}

	/*
	void Start()
	{
		obstacleSlider = GetComponent<Slider>();
	}

    void SetNumObstacles()
    {
    	Debug.Log(obstacleSlider.value);
    	numObstacleText.text = obstacleSlider.value.ToString();
    }
    */
}