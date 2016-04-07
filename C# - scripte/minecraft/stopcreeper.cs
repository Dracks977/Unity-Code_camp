using UnityEngine;
using System.Collections;

public class stopcreeper : MonoBehaviour {
	public GameObject creeper;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter (Collider col) {
		if (col.gameObject.layer == 10) {
			creeper.GetComponent<enemyfollow> ().onkack = true;
			creeper.GetComponent<enemyfollow> ().follow = false;
		}
	}
	void OnTriggerExit (Collider col) {

		creeper.GetComponent<enemyfollow> ().onkack = false;
		creeper.GetComponent<enemyfollow> ().follow = true;
	}
}
