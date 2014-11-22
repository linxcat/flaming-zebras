﻿using UnityEngine;
using System.Collections;

public class StatShop : Usable {

	protected PlayerData.Attribute stat;
	public GUIText ShopTextP1;
	public GUIText ShopTextP2;
	public GUIText ShopTextP3;
	public GUIText ShopTextP4;
	public GUITexture backgroundP1;
	public GUITexture backgroundP2;
	public GUITexture backgroundP3;
	public GUITexture backgroundP4;

	protected string DisplayData;

	public override void Use(GameObject caller)
	{
		if (caller.tag == "Player") //only acknowledge players
		{
			PlayerData playerData = caller.GetComponent<PlayerData>();
			int statLevel = playerData.GetAttributeLevel(stat);
			if (statLevel < 3)
				playerData.LevelUp(stat, statLevel + 1);
		}
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Player")
		{
			int playerNum = other.GetComponent<PlayerData>().GetPlayerNum();
			switch (playerNum)
			{
			case 1 :
			{
				ShopTextP1.gameObject.layer = LayerMask.NameToLayer( "Player1GUI" );
				backgroundP1.gameObject.layer = LayerMask.NameToLayer( "Player1GUI" );
				ShopTextP1.text = DisplayData;
				break;
			}
			case 2 :
			{
				ShopTextP2.gameObject.layer = LayerMask.NameToLayer( "Player2GUI" );
				backgroundP2.gameObject.layer = LayerMask.NameToLayer( "Player2GUI" );
				ShopTextP2.text = DisplayData;
				break;
			}
			case 3 :
			{
				ShopTextP3.gameObject.layer = LayerMask.NameToLayer( "Player3GUI" );
				backgroundP3.gameObject.layer = LayerMask.NameToLayer( "Player3GUI" );
				ShopTextP3.text = DisplayData;
				break;
			}
			case 4 :
			{
				ShopTextP4.gameObject.layer = LayerMask.NameToLayer( "Player4GUI" );
				backgroundP4.gameObject.layer = LayerMask.NameToLayer( "Player4GUI" );
				ShopTextP4.text = DisplayData;
				break;
			}
			}

		}
	}
	void OnTriggerExit2D(Collider2D other)
	{
		if(other.tag == "Player")
		{
			int playerNum = other.GetComponent<PlayerData>().GetPlayerNum();
			switch (playerNum)
			{
			case 1 :
			{
				ShopTextP1.gameObject.layer = LayerMask.NameToLayer ("NoGUI");
				backgroundP1.gameObject.layer = LayerMask.NameToLayer( "NoGUI" );
				break;
			}
			case 2 :
			{
				ShopTextP2.gameObject.layer = LayerMask.NameToLayer ("NoGUI");
				backgroundP2.gameObject.layer = LayerMask.NameToLayer( "NoGUI" );
				break;
			}
			case 3 :
			{
				ShopTextP3.gameObject.layer = LayerMask.NameToLayer ("NoGUI");
				backgroundP3.gameObject.layer = LayerMask.NameToLayer( "NoGUI" );
				break;
			}
			case 4 :
			{
				ShopTextP4.gameObject.layer = LayerMask.NameToLayer ("NoGUI");
				backgroundP4.gameObject.layer = LayerMask.NameToLayer( "NoGUI" );
				break;
			}
			}
		}
	}
}
