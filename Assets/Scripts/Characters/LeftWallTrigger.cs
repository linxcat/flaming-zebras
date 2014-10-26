﻿using UnityEngine;
using System.Collections;

public class LeftWallTrigger : MonoBehaviour {

	private PlayerData playerData;
	private Movement movement;

	void Awake()
	{
		playerData = transform.parent.GetComponent<PlayerData>();
		movement = transform.parent.GetComponent<Movement>();
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//stop player from moving or dashing towards a wall they are touching
	void OnTriggerStay2D (Collider2D other)
	{
		if (other.gameObject.tag == "Wall")
		{
			movement.wallLeft = true;
			if ( playerData.IsDashing() )
				movement.StopDash();
		}
			
	}

	//allow movement and dashing agin on exiting wall collision
	void OnTriggerExit2D (Collider2D other)
	{
		if (other.gameObject.tag == "Wall")
			movement.wallLeft = false;
	}
}