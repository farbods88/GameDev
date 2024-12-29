using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.T))
		{
			bool isActive = player.activeSelf;
			player.SetActive (!isActive);
			
			// gameObject.SetActive (!gameObject.activeSelf);
			// Debug.Log("Player Toggle");
		}
	}
}
