using UnityEngine;
using System.Collections;

public class mort : MonoBehaviour {
	public GameObject licorne;
	public GameObject cam;
	public GameObject menu;
	public GameObject oldui;
	public GameObject pause;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D(Collision2D coll){

		if (coll.gameObject.layer == 13 || coll.gameObject.layer == 9 ) {
			pause.SetActive (false);
			cam.SetActive (true);
			Destroy (licorne);
			oldui.SetActive (false);
			menu.SetActive (true);
			Destroy (this);
		} 
	}
}
