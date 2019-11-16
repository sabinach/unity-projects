using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAgents;

public class RollerAgent : Agent
{
    Rigidbody rb;
	public Transform Target;
	
	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}
	
	// reset the agent when it falls off the ground
	public override void AgentReset()
	{
		if (this.transform.position.y < 0)
		{
			// if agent falls, set momentum to 0
			this.rb.angularVelocity = Vector3.zero;
			this.rb.velocity = Vector3.zero;
			this.transform.position = new Vector3(0, 0.5f, 0);
		}
		
		// move target to new spot
		float new_x = Random.value * 8 - 4;
		float new_y = 0.5f;
		float new_z = Random.value * 8 - 4;
		Target.position = new Vector3(new_x, new_y, new_z); 
		
	}
	
	// get agent observations of the world
	public override void CollectObservations()
	{
		
	}
	
}
