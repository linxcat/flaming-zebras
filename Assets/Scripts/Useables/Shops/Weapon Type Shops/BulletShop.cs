﻿using UnityEngine;
using System.Collections;

public class BulletShop : WeaponShop {

	// Use this for initialization
	public override void Start () {
		base.Start();
		weapon = Weapon.WeaponType.Bullet;
		DisplayData = 
			"Bullet Shop\n" +
			" -Switch to Bullet\n" +
			"1: Pistol\n" +
			"2: Machine Gun\n" +
			"3: Shotgun\n" +
				"Price: ";
	}
}
