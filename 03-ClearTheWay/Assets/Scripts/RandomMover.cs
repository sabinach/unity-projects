using UnityEngine;

public class RandomMover : MonoBehaviour
{
    // ground dimensions
	public Transform ground;
	private float groundMinX;
	private float groundMaxX;
	private float groundMinZ;
	private float groundMaxZ;
	private float groundY;

	// delay time for new position generation
	private float delayTime;
	private float timer = 0f;

	// object goal position
	private Vector3 goalPosition;

	// object speed;
	[SerializeField] private float speed = 8f;

	// object y scale;
	private float obstacleY;

	void Start()
	{
		// min/max ground dimensions
		groundMinX = ground.lossyScale.x / -2f;
		groundMaxX = ground.lossyScale.x / 2f;
		groundMinZ = ground.lossyScale.z / -2f;
		groundMaxZ = ground.lossyScale.z / 2f;

		// bottom of ground
        groundY = ground.lossyScale.y;

        // current obstacle's y scale
        obstacleY = transform.lossyScale.y;

		getNewPosition();
	}

	void Update()
	{
		timer += Time.deltaTime;
		delayTime = UnityEngine.Random.Range(5, 10);

		if (timer > delayTime)
		{
			getNewPosition();
			timer = 0f;
		}
		transform.position = Vector3.MoveTowards(transform.position, goalPosition, speed*Time.deltaTime);
	}

	void getNewPosition()
	{
		// random position within ground bounds
		float randomX = UnityEngine.Random.Range(groundMinX, groundMaxX);
	    float randomZ = UnityEngine.Random.Range(groundMinZ, groundMaxZ);

	    if(gameObject.tag=="Plower")
	    	groundY = 1.8f;
	    goalPosition = new Vector3(randomX, groundY, randomZ);
	}
}
