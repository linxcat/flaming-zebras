﻿using UnityEngine;
using System.Collections;

public class CameraShift : MonoBehaviour {
	
	public PlayerData playerData;

	void Start()
	{
		playerData = transform.parent.GetComponent<PlayerData>();
	}

	// set the cameras for all the players based on the number of players and playerNum
	// This is for when we have a dynamic number of players. 
	// This is currently broken due to a bug in PlayerData, where the apparently static numplayers isn't acting very static
	public void UpdateViewport() {
		
		switch (PlayerData.NUMPLAYERS) 
		{
			case 2: //If there are 2 players total
			{
				print("2 players");
				switch (playerData.GetPlayerNum ()) 
				{
					case 1:
					{
						print("Player 1");
						//set camera for player 1
						camera.rect = new Rect (0f, 0.5f, 1f, 0.5f);
						break;
					}
					case 2:
					{
						print("Player 2");
						//set camera for player 2
						camera.rect = new Rect (0f, 0f, 1f, 0.498f);
						break;
					}
				}
				break;
			}
			case 3: //If there are 3 players total
			{
				print("3 players");
				switch (playerData.GetPlayerNum ()) 
				{
				case 1:
				{
					print("Player 1");
					//set camera for player 1
					camera.rect = new Rect (0f, 0.5f, 0.498f, 0.5f);
					break;
				}
				case 2:
				{
					print("Player 2");
					//set camera for player 2
					camera.rect = new Rect (0.502f, 0.5f, 1f, 1f);
					break;
				}
				case 3:
				{
					print("Player 3");
					//set camera for player 3
					camera.rect = new Rect (0f, 0f, 1f, 0.5f);
					break;
				}
				}
				break;
			}
			case 4: //If there are 4 players total
			{
				print("4 players");
				switch (playerData.GetPlayerNum ()) 
				{
					case 1:
					{
						print("Player 1");
						// set camera for player 1
						camera.rect = new Rect (0f, 0.5f, 0.498f, 0.5f);
						break;
					}
					case 2:
					{
						print("Player 2");
						// set camera for player 2
						camera.rect = new Rect (0.502f, 0.5f, 1f, 1f);
						break;
					}
					case 3:
					{
						print("Player 3");
						// set camera for player 3
						camera.rect = new Rect (-0.002f, 0f, 0.5f, 0.498f);
						break;
					}
					case 4:
					{
						print("Player 3");
						// set camera for player 4
						camera.rect = new Rect (0.502f, 0f, 0.5f, 0.498f);
						break;
					}
				}
				break;
			}
		}
	}
}
