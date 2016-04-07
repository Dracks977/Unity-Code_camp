using UnityEngine;
using System.Collections;

public class degatzobi : MonoBehaviour {
	public GameObject vie;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider col) {
		if (col.gameObject.layer == 30) {
			vie.GetComponent<vie> ().Pvie -= 1;
		}
	}
}
