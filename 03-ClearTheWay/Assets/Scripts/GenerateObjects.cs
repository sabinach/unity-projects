using UnityEngine;

public class GenerateObjects : MonoBehaviour
{
	// get obstacle prefab
	public GameObject obstacle;
	public GameObject plower;
	public GameObject eater;
	public GameObject treat;

	public int numObstacles = 15;
	public int numPlowers = 5;
	public int numEaters = 3;
	public int numTreats = 4;

	// ground dimensions
	public Transform ground;
	private float groundMinX;
	private float groundMaxX;
	private float groundMinZ;
	private float groundMaxZ;
	private float groundY;

	// object y scale;
	private float obstacleY;
	private float plowerY;
	private float eaterY;
	private float treatY;

	void Start()
	{
		// min/max obstacle spawn position
		groundMinX = ground.lossyScale.x / -2f;
		groundMaxX = ground.lossyScale.x / 2f;
		groundMinZ = ground.lossyScale.z / -2f;
		groundMaxZ = ground.lossyScale.z / 2f;

		// bottom of ground
        groundY = ground.lossyScale.y;

        // current object's y scale
        obstacleY = 0.5f; //transform.lossyScale.y;
        plowerY = 0.8f; // plower.transform.lossScale.y;
        eaterY = 0f; //eater.transform.lossScale.y;
        treatY = treat.transform.lossyScale.y;

        // activate prefabs
        obstacle.SetActive(true);
        plower.SetActive(true);
        eater.SetActive(true);
        treat.SetActive(true);

		// generate specified number of objects
		Generate(numObstacles, obstacle, obstacleY);
		Generate(numPlowers, plower, plowerY);
		Generate(numEaters, eater, eaterY);
		Generate(numTreats, treat, treatY);
	}

	void Generate(int numObjects, GameObject objectPrefab, float objectY)
	{
		if (numObjects <= 0)
		{
			Destroy(objectPrefab);
		}
		else
		{
			// generate specified number of objects
			for(int i = 0; i < numObjects-1; ++i)
			{
				// create new object
				GameObject newObject = Instantiate(objectPrefab) as GameObject;

				// random position within ground bounds
				float randomX = UnityEngine.Random.Range(groundMinX, groundMaxX);
		    	float randomZ = UnityEngine.Random.Range(groundMinZ, groundMaxZ);
		    	newObject.transform.position = new Vector3(randomX, groundY + objectY, randomZ);
			}
		}
	}
}
