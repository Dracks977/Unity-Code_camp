/*coded by Dracks*/
using UnityEngine;
using System.Collections;

public class boumcreeper : MonoBehaviour {
	public float timerboum;
	public GameObject life;
	public GameObject shiiit;
	public bool canexplose = false;
	public GameObject coffeedemerde;
	public GameObject creeper;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (canexplose == true) {
			if (timerboum <= Time.time) {
				coffeedemerde.SetActive (true);
				life.GetComponent<vie> ().Pvie -= 3;
				Destroy (creeper);
			}
		}
	}

	void OnTriggerEnter (Collider col) {
		if (col.gameObject.layer == 10) {
			canexplose = true;
			timerboum = (Time.time + 2f);
			shiiit.SetActive (true);
			creeper.GetComponent<Animation>().Play ("boom");
		}
	}
	void OnTriggerExit (Collider col) {
		if (col.gameObject.layer == 10) {
			shiiit.SetActive (false);
			creeper.GetComponent<Animation> ().Stop ();
			timerboum = 1000000000f;
		}
	}
}
