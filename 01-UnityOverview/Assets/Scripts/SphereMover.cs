using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMover : MonoBehaviour
{
	private void OnEnable()
	{
		Respawn();
	}

	// Update is called once per frame
    void Update()
    {
    	// if sphere goes below -10 y-axis
        if(transform.position.y < -10)
        	Respawn();
    }

    private void Respawn()
    {
    	// respawn at random point
    	float randomX = UnityEngine.Random.Range(-10, 10);
    	float randomY = UnityEngine.Random.Range(10, 20);
    	transform.position = new Vector3(randomX, randomY);

    	// respawn at 0 velocity
    	var rigidbody = GetComponent<Rigidbody>();
    	rigidbody.velocity = Vector3.zero;
    }
}
