using UnityEngine;
using UnityEngine.UI;

public class Obstacle : MonoBehaviour
{

	// ground variables
	public Transform ground;
	private float groundMinY;

	// private variables
	private string lastCollision;
	private Score score1;
	private Score score2;

	// score reference
	public Text scoreText1;
	public Text scoreText2;

	void Start()
	{
		// prevent cube rolling
		GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
		
		// bottom of ground
		groundMinY = -ground.lossyScale.y;

		// scores
		score1 = scoreText1.GetComponent<Score>();
		score2 = scoreText2.GetComponent<Score>();
	}

	void Update()
	{
		if(transform.position.y < groundMinY)
		{
			if(lastCollision == "Player1")
				score1.score += 1;
			if(lastCollision == "Player2")
				score2.score += 1;
			Destroy(gameObject);
		}
	}

	void OnCollisionEnter(Collision collision)
	{
		// get name of last object collision
		lastCollision = collision.gameObject.name;
	}

}
