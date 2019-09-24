using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
	public PlayerMovement movement;

	void OnCollisionEnter(Collision collisionInfo)
	{
		if(collisionInfo.collider.tag == "Obstacle")
		{
			//Debug.Log("Hit Obstacle");
			movement.enabled = false; // can also sub "movement" w/ GetComponent<PlayerMovement>().enabled = false;

			//end game
			FindObjectOfType<GameManager>().EndGame();

		}
	}
}
