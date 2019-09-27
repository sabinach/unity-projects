using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject obstacle;

    // score reference
	public Text scoreText1;
	public Text scoreText2;
	private Score score1;
	private Score score2;

	// winner text
	public GameObject winner;
	public Text winnerText;

	void Start()
	{
		// scores
		score1 = scoreText1.GetComponent<Score>();
		score2 = scoreText2.GetComponent<Score>();
	}

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectsWithTag("Obstacle").Length == 0)
        {
        	// display respective congratulatory text
        	if(score1.score > score2.score)
        	{
        		winnerText.text = "Player 1 Wins!";
        	}
        	if(score1.score < score2.score)
        	{
        		winnerText.text = "Player 2 Wins!";
        	}
        	if(score1.score == score2.score)
        	{
        		winnerText.text = "Tie!";
        	}

        	// enable winner text
        	winner.SetActive(true);
        }
    }
}
