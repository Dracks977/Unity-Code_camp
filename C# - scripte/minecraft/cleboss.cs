using UnityEngine;
using System.Collections;

public class cleboss : MonoBehaviour {
	public GameObject image;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter (Collider col) {
		image.SetActive (true);
		Destroy (this.gameObject);
	}
}
