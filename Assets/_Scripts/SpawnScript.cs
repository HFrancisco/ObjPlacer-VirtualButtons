using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {

	private string toSpawn;
	private GameObject obj;
	[SerializeField] private Camera arCamera;

	private List<GameObject> placedObjects;

	[SerializeField] GameObject Building1;
	[SerializeField] GameObject Building2;
	[SerializeField] GameObject Building3;
	[SerializeField] GameObject Building4;
	[SerializeField] GameObject Building5;
	[SerializeField] GameObject Building6;

	// Use this for initialization
	void Start () {
		toSpawn = "";
		this.placedObjects = new List<GameObject> ();

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {

			toSpawn = FindObjectOfType<MasterBuildingScript> ().GetToSpawn ();
			Ray ray = this.arCamera.ScreenPointToRay(Input.mousePosition);
			Debug.DrawRay (ray.origin, ray.direction, Color.red);

			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) {
				Vector3 hitPos = hit.point;
				Debug.Log ("Hit pos: " + hitPos);

				if (toSpawn.Length > 0) {
					Debug.Log ("spawn is " + toSpawn);
					if(Physics.Raycast(ray, out hit, 100)){

						if (toSpawn.Equals ("1")) {

							GameObject spawnObject = GameObject.Instantiate (Building1, this.transform);
							spawnObject.transform.position = hitPos;
							spawnObject.SetActive (true);
							this.placedObjects.Add (spawnObject);

						} else if (toSpawn.Equals ("2")) {

							GameObject spawnObject = GameObject.Instantiate (Building2, this.transform);
							spawnObject.transform.position = hitPos;
							spawnObject.SetActive (true);
							this.placedObjects.Add (spawnObject);

						} else if (toSpawn.Equals ("3")) {

							GameObject spawnObject = GameObject.Instantiate (Building3, this.transform);
							spawnObject.transform.position = hitPos;
							spawnObject.SetActive (true);
							this.placedObjects.Add (spawnObject);

						} else if (toSpawn.Equals ("4")) {

							GameObject spawnObject = GameObject.Instantiate (Building4 , this.transform);
							spawnObject.transform.position = hitPos;
							spawnObject.SetActive (true);
							this.placedObjects.Add (spawnObject);

						} else if (toSpawn.Equals ("5")) {

							GameObject spawnObject = GameObject.Instantiate (Building5 , this.transform);
							spawnObject.transform.position = hitPos;
							spawnObject.SetActive (true);
							this.placedObjects.Add (spawnObject);

						} else if (toSpawn.Equals ("6")) {

							GameObject spawnObject = GameObject.Instantiate (Building6 , this.transform);
							spawnObject.transform.position = hitPos;
							spawnObject.SetActive (true);
							this.placedObjects.Add (spawnObject);

						}
					}
				}

			}
		}
	}

	public void ShowHideToggle(){
		
		if (this.placedObjects.Count == 0) {
			return;
		}

		for(int i = 0; i < this.placedObjects.Count; i++) {	

			if (this.placedObjects [i].activeSelf) {
				this.placedObjects [i].SetActive (false);
			} else {
				this.placedObjects [i].SetActive (true);
			}
		}
	}

	public void Delete(){
		
		for(int i = 0; i < this.placedObjects.Count; i++) {
			GameObject.Destroy (this.placedObjects [i]);
		}

		this.placedObjects.Clear ();
	}
}
