﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : AGun
{

	public Rifle ()
	{
//		Bullet = GameObject.Find ("Bullet");
//		Bullet;
		TimeBetweenshots = .1f;
		Name = "Rifle";
		TotalAmmo = 300;
		Ammo = MagazineCap = 30;

	}
	public override void Fire (Player player)
	{

		if (Ammo > 0 && Time.time >= TimeNextShot) {
			TimeNextShot = Time.time + TimeBetweenshots;
			ABullet bullet = Instantiate (Bullet, player.transform.position, player.transform.rotation);
			Ammo--;
		}
	}


}
