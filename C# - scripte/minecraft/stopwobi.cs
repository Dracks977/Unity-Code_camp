using UnityEngine;
using System.Collections;

public class stopwobi : MonoBehaviour {

	public GameObject zobi;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter (Collider col) {
		if (col.gameObject.layer == 10) {
			zobi.GetComponent<followzobi> ().onkack = true;
			zobi.GetComponent<followzobi> ().follow = false;
		}
	}
	void OnTriggerExit (Collider col) {
		zobi.GetComponent<followzobi> ().onkack = false;
		zobi.GetComponent<followzobi> ().follow = true;

	}
}

