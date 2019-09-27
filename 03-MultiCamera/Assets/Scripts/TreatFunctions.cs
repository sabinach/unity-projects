using UnityEngine;
using UnityEngine.UI;

public class TreatFunctions : MonoBehaviour
{
    // private variables
	private string lastCollision;
	private Score score1;
	private Score score2;

	// score reference
	public Text scoreText1;
	public Text scoreText2;

    // Start is called before the first frame update
    void Start()
    {
        // scores
		score1 = scoreText1.GetComponent<Score>();
		score2 = scoreText2.GetComponent<Score>();
    }

    void OnCollisionEnter(Collision collision)
	{
		// get name of last object collision
		lastCollision = collision.gameObject.name;

		if(lastCollision == "Player1")
			score1.score += 0.5f;
		if(lastCollision == "Player2")
			score2.score += 0.5f;
		Destroy(gameObject);
	}
}
