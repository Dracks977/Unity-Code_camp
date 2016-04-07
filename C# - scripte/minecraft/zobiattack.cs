using UnityEngine;
using System.Collections;

public class zobiattack : MonoBehaviour {

	//coded by dracks ;)
	public int vie = 5;
	public Collider sword;
	public bool canhit = false;
	private float temps;
	public float coultdown = 0.5f;
	public AudioSource qudio;
	public GameObject zobi;
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
			zobi.gameObject.SetActive(false);
		}
	}
	void OnTriggerEnter (Collider col) {
		if (col.gameObject.layer == 9 && canhit == true) {
			sword.enabled = false;
			if (temps > Time.time ){
				qudio.Play ();
				vie--;
			}
			canhit = false;
		}
	}
}
