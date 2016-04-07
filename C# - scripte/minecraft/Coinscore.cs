using UnityEngine;
using System.Collections;

public class Coinscore : MonoBehaviour {
	public GameObject Scoredcript;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter (Collider col) {
		Scoredcript.GetComponent<score> ().Totalscore += 1;
		Destroy (this.gameObject);
	}
}
