using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
	// current player version
	public int numPlayers = 2;

	// object generation script
	public GenerateObjects generateObjects;

	// get/set ground dimensions
	public Transform ground;

	// level descriptions
	public Text easyNumObjText;
	public Text mediumNumObjText;
	public Text hardNumObjText;

	// 2 players
	[SerializeField] private int two_easy_obstacles = 5;
	[SerializeField] private int two_easy_plowers = 2;
	[SerializeField] private int two_easy_eaters = 2;
	[SerializeField] private int two_easy_treats = 5;

	[SerializeField] private int two_medium_obstacles = 10;
	[SerializeField] private int two_medium_plowers = 4;
	[SerializeField] private int two_medium_eaters = 4;
	[SerializeField] private int two_medium_treats = 10;

	[SerializeField] private int two_hard_obstacles = 15;
	[SerializeField] private int two_hard_plowers = 6;
	[SerializeField] private int two_hard_eaters = 6;
	[SerializeField] private int two_hard_treats = 15;

	void Start()
	{
		// update level description (based on num players + level)

		// ******* 2 players ******* //
		SetLevelText(easyNumObjText, two_easy_obstacles, two_easy_plowers, two_easy_eaters, two_easy_treats); // easy
		SetLevelText(mediumNumObjText, two_medium_obstacles, two_medium_plowers, two_medium_eaters, two_medium_treats); // medium
		SetLevelText(hardNumObjText, two_hard_obstacles, two_hard_plowers, two_hard_eaters, two_hard_treats); // hard

	}

	public void Easy()
	{
		if (numPlayers == 2)
		{
			// set ground to 50x50
			//ground.lossyScale.x = 25;
			//ground.lossyScale.y = 25;

			SetLevelObstacles(two_easy_obstacles, two_easy_plowers, two_easy_eaters, two_easy_treats);
			SceneManager.LoadScene("TwoPlayers");
		}
	}

	public void Medium()
	{
		if (numPlayers == 2)
		{
			SetLevelObstacles(two_medium_obstacles, two_medium_plowers, two_medium_eaters, two_medium_treats);
			SceneManager.LoadScene("TwoPlayers");
		}
	}

	public void Hard()
	{
		if (numPlayers == 2)
		{
			SetLevelObstacles(two_hard_obstacles, two_hard_plowers, two_hard_eaters, two_hard_treats);
			SceneManager.LoadScene("TwoPlayers");
		}
	}

	public void Custom()
	{

	}

	// set the public variable values for specified num of objects
	void SetLevelObstacles(int numObstacles, int numPlowers, int numEaters, int numTreats)
	{
		// set number of objects generated for this level
		generateObjects.numObstacles = numObstacles;
		generateObjects.numPlowers = numPlowers;
		generateObjects.numEaters = numEaters;
		generateObjects.numTreats = numTreats;
	}

	// set the text description of the level
	void SetLevelText(Text textObject, int numObstacles, int numPlowers, int numEaters, int numTreats)
	{
		textObject.text = numObstacles + " Obstacles, " + numPlowers + " Plowers, " + numEaters + " Eaters, " + numTreats + " Treats";
	}


}
