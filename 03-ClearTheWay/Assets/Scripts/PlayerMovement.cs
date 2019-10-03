using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	[SerializeField] private string vertical = "Vertical1";
    [SerializeField] private string horizontal = "Horizontal1";
    
    [SerializeField] private float speed = 10f;
    [SerializeField] private float rotateSpeed = 50f;
    //[SerializeField] private float respawnTime = 3f;

    private Vector3 movement;
    private float rotation;

    public Transform ground;
    private float groundMinX;
    private float groundMaxX;
    private float groundMinZ;
    private float groundMaxZ;
    private float groundY;

    void Start()
    {
        // min/max obstacle spawn position
        groundMinX = ground.lossyScale.x / -2f;
        groundMaxX = ground.lossyScale.x / 2f;
        groundMinZ = ground.lossyScale.z / -2f;
        groundMaxZ = ground.lossyScale.z / 2f;

        // bottom of ground
        groundY = ground.lossyScale.y;
    }

    void Update()
    {
    	movement.z = Input.GetAxis(vertical) * speed * Time.deltaTime;
    	rotation = Input.GetAxis(horizontal) * rotateSpeed * Time.deltaTime;

        // if player falls off, wait respawnTime and respawn at map center
        if(transform.position.y < -groundY)
        {
            //freeze player for specific amount of time before letting them move
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
        this.GetComponent<Rigidbody>().velocity = Vector3.zero; // zero velocity

        // random position within ground bounds
        float randomX = UnityEngine.Random.Range(groundMinX, groundMaxX);
        float randomZ = UnityEngine.Random.Range(groundMinZ, groundMaxZ);

        transform.position = new Vector3(randomX, groundY, randomZ); // center of map
        transform.rotation = Quaternion.identity; // right-side up
    }

    // not used yet
    IEnumerator Freeze()
    {
        yield return new WaitForSeconds(3);
    }
}