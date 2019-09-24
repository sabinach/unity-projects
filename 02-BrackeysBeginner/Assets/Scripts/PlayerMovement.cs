using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public Rigidbody rb;
	[SerializeField] private float forwardForce = 5000f;
	[SerializeField] private float sideForce = 100f;

	// Update is called once per frame
    // Use FixedUpdate() for physics
    void FixedUpdate()
    {
    	// forward force
        rb.AddForce(0, 0, forwardForce*Time.deltaTime);

        // left
        if(Input.GetKey("a"))
        	rb.AddForce(-sideForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        // right
        if(Input.GetKey("d"))
        	rb.AddForce(sideForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        if(rb.position.y < -1f)
        	FindObjectOfType<GameManager>().EndGame();
    }
}
