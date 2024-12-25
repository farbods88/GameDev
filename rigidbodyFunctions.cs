using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyPractice : MonoBehaviour {


	private Rigidbody rb;
	// Use this for initialization
	void Start () 
	{
	//Get the rigidbody component attached to the object.
		rb = GetComponent <Rigidbody>();
	//Apply an upward force when the game starts
		//rb.AddForce(Vector3.up * 500);
	}
	//Keyboard key code A to Z = KeyCode.A ... KeyCode.Z 
	//Arrow keys left arrow = KeyCode.LeftArrow ...
	//Numbers 0 to 9 = KeyCode.Alpha0 to Alpha9
	//Enter = KeyCode.Return
	// Function Keys = KeyCode.F1 to F12
	// Update is called once per frame
	void Update () 
	{

		if (Input.GetKeyDown (KeyCode.Space))
		{
			rb.AddForce(Vector3.up * 150);
		}
		if (Input.GetKeyDown (KeyCode.Mouse0))
		{
			rb.AddForce(Vector3.right * 150);
		}
		if (Input.GetKeyDown (KeyCode.Return))
		{
			rb.velocity = Vector3.zero;
		}
		
	}
}
