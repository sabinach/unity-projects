using UnityEngine;

public class Obstacle : MonoBehaviour
{
	void Start()
	{
		// prevent cube rolling
		GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
	}

}
