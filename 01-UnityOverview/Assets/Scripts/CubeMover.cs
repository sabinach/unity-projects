using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CubeMover : MonoBehaviour
{
	[SerializeField] private float speed = 1;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(x, y);
        transform.position += movement * Time.deltaTime * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
    	//collision.collider.getComponent
    	SceneManager.LoadScene(0);
    }
}
