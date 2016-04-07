using UnityEngine;
using System.Collections;

public class porteboss : MonoBehaviour {
	public GameObject image;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter (Collider col) {
		if (col.gameObject.name == "player") {
			if (image.activeSelf == true) {
				image.SetActive (false);
				this.gameObject.SetActive (false);
			}
		}
	}
}
