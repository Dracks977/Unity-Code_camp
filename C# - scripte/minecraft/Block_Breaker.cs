/*coded by Dracks*/
using UnityEngine;
using System.Collections;

public class Block_Breaker : MonoBehaviour {
	public int vie = 3;
	public Collider Pickaxe;
	public bool canhit = false;
	private float temps;
	public float coultdown = 0.5f;
	public AudioSource qudio;
	public Material break1;
	public Material break2;

	// Update is called once per frame
	void Start () { 
		temps = (Time.time + coultdown);
		Pickaxe.enabled = false;
	}

	void Update () {
		if (temps <= Time.time && Input.GetKey (KeyCode.Mouse0)) {
			Pickaxe.enabled = true;
			canhit = true;
			temps = (Time.time + coultdown);
		}
		if (vie == 0) {
			Destroy (this.gameObject);
		} 
		else if (vie == 2){
			GetComponent<Renderer> ().material = break1;
		}
		else if (vie == 1){
			GetComponent<Renderer> ().material = break2;
		}
	}


	
	void OnTriggerEnter (Collider col) {
		if (col.gameObject.layer == 8 && canhit == true) {  
			Pickaxe.enabled = false;
			if (temps > Time.time){
				qudio.Play ();
				vie--;
			}
			canhit = false;
		}
	}
}
