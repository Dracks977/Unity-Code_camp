/* Coded by Dracks - vanhem_n@etna-alternance.net*/
using UnityEngine;
using System.Collections;

public class opencoffre : MonoBehaviour {
	public GameObject indicator;
	public bool ontrigerornot = false;
	public GameObject pickaxeitem;

	public GameObject coffre;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (ontrigerornot == true) {
			if (Input.GetKey ("e")) {
				pickaxeitem.SetActive (true);
				Destroy (coffre);
			}
		}
	}
	void OnTriggerEnter (Collider col) {
		if (col.gameObject.layer == 10) {
			indicator.SetActive (true);
			ontrigerornot = true;
		}
	}
	void OnTriggerExit (Collider col) {
		if (col.gameObject.layer == 10) {
			indicator.SetActive (false);
			ontrigerornot = false;
		}
	}

}
