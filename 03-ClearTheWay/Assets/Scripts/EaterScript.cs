using UnityEngine;
using UnityEngine.UI;

public class EaterScript : MonoBehaviour
{
	// player objects
	public GameObject player1;
	public GameObject player2;

	// private variables
	private string lastCollision;
	private Score score1;
	private Score score2;

	// score reference
	public Text scoreText1;
	public Text scoreText2;

	// ground variables
	public Transform ground;
	private float groundMinY;

    // Start is called before the first frame update
    void Start()
    {
        // scores
		score1 = scoreText1.GetComponent<Score>();
		score2 = scoreText2.GetComponent<Score>();

		// bottom of ground
		groundMinY = -ground.lossyScale.y;
    }

    void Update()
    {
    	if(transform.position.y < groundMinY)
    		Destroy(gameObject);
    }

	void OnCollisionEnter(Collision collision)
	{
		// get name of last object collision
		lastCollision = collision.gameObject.name;

		if(lastCollision == "Player1")
			score1.score -= 0.25f;
		if(lastCollision == "Player2")
			score2.score -= 0.25f;
	}
}
