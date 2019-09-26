using UnityEngine;

public class GenerateObstacles : MonoBehaviour
{
	// get obstacle prefab
	public GameObject obstacle;
	[SerializeField] private int numObjects = 5;

	// ground dimensions
	public Transform ground;
	private float groundMinX;
	private float groundMaxX;
	private float groundMinZ;
	private float groundMaxZ;

	void Start()
	{
		// min/max obstacle spawn position
		groundMinX = ground.lossyScale.x / -2f;
		groundMaxX = ground.lossyScale.x / 2f;
		groundMinZ = ground.lossyScale.z / -2f;
		groundMaxZ = ground.lossyScale.z / 2f;

		Generate();
	}

	void Generate()
	{
		for(int i = 0; i < numObjects; ++i)
		{
			// create new obstacle object
			GameObject newObstacle = Instantiate(obstacle) as GameObject;

			// random position within ground bounds
			float randomX = UnityEngine.Random.Range(groundMinX, groundMaxX);
	    	float randomZ = UnityEngine.Random.Range(groundMinZ, groundMaxZ);
	    	newObstacle.transform.position = new Vector3(randomX, 1.5f, randomZ);

	    	Debug.Log(i);
		}
	}
}
