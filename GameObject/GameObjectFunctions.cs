using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectPractise : MonoBehaviour {

	public GameObject coinPrefab;
	public Transform spawnPoint;
	

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.C))
		{
			Instantiate (coinPrefab, spawnPoint.position, Quaternion.identity);
			Debug.Log("Coin Spawned");
		}

		if (Input.GetKeyDown (KeyCode.F))
		{
			Destroy (gameObject);
			Debug.Log("Destroyed");
		}

		
	}

	
}
