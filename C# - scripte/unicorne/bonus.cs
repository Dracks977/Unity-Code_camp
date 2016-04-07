using UnityEngine;
using System.Collections;

public class bonus : MonoBehaviour {
	public GameObject lll;
	public GameObject objWithScript;
	Score scriptRef;

	// Use this for initialization
	void Start () {
		scriptRef = objWithScript.GetComponent<Score>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D coll){
		scriptRef.count += 1;
		Destroy (lll);
	}
}