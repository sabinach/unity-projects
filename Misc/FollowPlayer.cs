using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

	public Transform player;
    [SerializeField] private Vector3 offset = new Vector3(0f, 1f, -5f);
    [SerializeField] private bool rotation = true;

    // Update is called once per frame
    // Camera follows behind player object
    void LateUpdate()
    {	
        transform.position = player.position + offset;

        if(rotation)
        {
        	//transform.rotation = Quaternion.Euler(0f, player.eulerAngles.y, 0f);
        	//transform.LookAt(player.transform);
        	transform.rotation = player.transform.rotation; //* Quaternion.Euler(0f, player.eulerAngles.y, 0f);

        }
    }
}
