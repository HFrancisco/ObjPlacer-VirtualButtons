﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B1Spawn : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ButtonClick(){
		FindObjectOfType<MasterBuildingScript> ().SetToSpawn ("1");
		Debug.Log ("B click");
	}
}
