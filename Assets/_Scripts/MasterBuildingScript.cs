using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterBuildingScript : MonoBehaviour {

	private string toSpawn;

	// Use this for initialization
	void Start () {
		toSpawn = "";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SetToSpawn(string pName){
		this.toSpawn = pName;
		Debug.Log ("Master is " + toSpawn);
	}

	public string GetToSpawn(){
		return toSpawn;
	}
}
