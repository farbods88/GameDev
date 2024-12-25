using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformPractice : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	// Move the object to the direction every frame.
		transform.Translate (Vector3.down * Time.deltaTime);
		transform.Translate (Vector3.up * Time.deltaTime);
		transform.Translate (Vector3.left * Time.deltaTime);
		transform.Translate (Vector3.right * Time.deltaTime);

	//Rotate the object slowly.
		transform.Rotate (0, 0, 45 * Time.deltaTime);
		transform.Rotate (Vector3.down * 45 * Time.deltaTime);
		transform.Rotate (Vector3.up * 45 * Time.deltaTime);
		transform.Rotate (Vector3.right * 45 * Time.deltaTime);
		transform.Rotate (Vector3.left * 45 * Time.deltaTime);

	//Make the object grow bigger in the specificed directions.
		transform.localScale += new Vector3(2,0,0) * Time.deltaTime;

		transform.localScale += Vector3.one * -Time.deltaTime;
	}
}
