﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGunBullet : ABullet {

	protected override void Update(){
        base.Update();
		Damage = 20f;
		Speed = 80f;
	}
}
