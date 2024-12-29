using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPractise : MonoBehaviour {

	public float moveSpeed = 20f; // Speed of movement

	private Rigidbody rb;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent <Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		float horizontal = Input.GetAxis ("Horizontal"); 
		float vertical = Input.GetAxis ("Vertical"); 
		
		//Input.GetKey checks if a specific key is held down but Input.GetKeyDown checks if a key was pressed this frame.
		if (Input.GetKey (KeyCode.Space)) 
		{
			transform.Translate (new Vector3(horizontal, vertical, 0) * moveSpeed * Time.deltaTime); // Move the player
		}


		if (Input.GetMouseButtonDown (0))
		{
			rb.AddForce (Vector3.right * 400);
		}
	}
}
