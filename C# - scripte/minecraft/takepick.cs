/* Coded by Dracks - vanhem_n@etna-alternance.net*/
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class takepick : MonoBehaviour {
	public GameObject piocheobj;
	public GameObject pickimage;
	pickorsword scripp;
	public GameObject item;

	// Use this for initialization
	void Start () {
		scripp = piocheobj.GetComponent<pickorsword> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter (Collider col) {
		if (col.gameObject.layer == 10) {
			scripp.haveapick = true;
			pickimage.SetActive (true);
			Destroy (item);
		}
}
}
