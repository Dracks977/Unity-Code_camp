using UnityEngine;
using System.Collections;

public class platmoveok : MonoBehaviour {
	public Transform plat;
	public GameObject player;
	void OnTriggerEnter (Collider col) {
		player.transform.parent = plat;
	}
	void OnTriggerExit (Collider col) {
		player.transform.parent = null;
	}	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
