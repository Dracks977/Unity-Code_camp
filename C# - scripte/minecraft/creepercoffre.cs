/* Coded by Dracks - vanhem_n@etna-alternance.net*/
using UnityEngine;
using System.Collections;

public class creepercoffre : MonoBehaviour {
	public GameObject coffre;
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

	// Update is called once per frame
	void Update () {
		if (temps <= Time.time && Input.GetKey (KeyCode.Mouse0)) {
			sword.enabled = true;
			canhit = true;
			temps = (Time.time + coultdown);
		}
		if (vie == 0) {
			Destroy (creeper.gameObject);
			coffre.SetActive (true);
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