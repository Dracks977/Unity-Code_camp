﻿using UnityEngine;
using System.Collections;

public class anim_sword : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0)) {
			GetComponent<Animation>().Play ("diamondsword");
		}
	}
}
