using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	[SerializeField] private string vertical = "Vertical1";
    [SerializeField] private string horizontal = "Horizontal1";
    
    [SerializeField] private float speed = 8f;
    [SerializeField] private float rotateSpeed = 50f;

    private Vector3 movement;
    private float rotation;

    void Update()
    {
    	movement.z = Input.GetAxis(vertical) * speed * Time.deltaTime;
    	rotation = Input.GetAxis(horizontal) * rotateSpeed * Time.deltaTime;
    }

    void FixedUpdate()
    {
    	transform.Translate(movement, Space.Self);
    	transform.Rotate(0f, rotation, 0f);
    }
}