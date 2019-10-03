using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    // player score (to be updated)
    public float score = 0f;

    void Update()
    {
    	// display score text
    	scoreText.text = score.ToString();
    }
}
