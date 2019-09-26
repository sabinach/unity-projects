using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	[SerializeField] private string vertical = "Vertical1";
    [SerializeField] private string horizontal = "Horizontal1";
    
    [SerializeField] private float speed = 10f;
    [SerializeField] private float rotateSpeed = 50f;
    [SerializeField] private float respawnTime = 3f;

    private Vector3 movement;
    private float rotation;

    public Transform ground;
    private float groundMinY;

    void Start()
    {
        // bottom of ground
        groundMinY = -ground.lossyScale.y;
    }

    void Update()
    {
    	movement.z = Input.GetAxis(vertical) * speed * Time.deltaTime;
    	rotation = Input.GetAxis(horizontal) * rotateSpeed * Time.deltaTime;

        // if player falls off, wait respawnTime and respawn at map center
        if(transform.position.y < groundMinY)
        {
            //yield return new WaitForSeconds(respawnTime);
            Respawn();
        }
    }

    void FixedUpdate()
    {
    	transform.Translate(movement, Space.Self);
    	transform.Rotate(0f, rotation, 0f);
    }

    void Respawn()
    {
        transform.position = new Vector3(0, 0, 0);
    }
}