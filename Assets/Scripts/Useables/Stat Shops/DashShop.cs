﻿using UnityEngine;
using System.Collections;

public class DashShop : StatShop {

	// Use this for initialization
	void Start () {
		stat = PlayerData.Attribute.Dash;
		DisplayData = 
			"Dash Shop: \n" +
			"Increases Dash distance\n" +
			"Price: ";

	}
}
