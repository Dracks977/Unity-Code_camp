using UnityEngine;
using System.Collections;

public class creeperattack : MonoBehaviour {
	public int vie = 10;
	public Collider sword;
	public bool canhit = false;
	private float temps;
	public float coultdown = 0.5f;
	public AudioSource qudio;
	public GameObject creeper;
	// Use this for initialization
	void Start () {
		temps = (Time.time + coultdown);
		sword.enabled = false;
	}
	void Update () {
		if (temps <= Time.time && Input.GetKey (KeyCode.Mouse0)) {
			sword.enabled = true;
			canhit = true;
			temps = (Time.time + coultdown);
		}
		if (vie == 0) {
			Destroy (creeper.gameObject);
		}
	}
	void OnTriggerEnter (Collider col) {
		if (col.gameObject.layer == 9 && canhit == true && col.transform.name != "boum") {
			sword.enabled = false;
			if (temps > Time.time ){
				qudio.Play ();
				vie--;
			}
			canhit = false;
		}
	}
}