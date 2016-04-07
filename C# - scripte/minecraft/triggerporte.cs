using UnityEngine;
using System.Collections;

public class triggerporte : MonoBehaviour {
	public bool No_More_Monster = false; //a mettre a faulse quans script mob
	public GameObject porte;
	public GameObject porte1;
	public GameObject porte2;
	public GameObject Supermusic;
	public GameObject zobi1;
	public GameObject zobi2;
	public bool enter1 = false;
	public GameObject after;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (No_More_Monster == true) { 
			porte.SetActive (false);
			porte1.SetActive (false);
			porte2.SetActive (false);
			Destroy (this.gameObject);
			after.SetActive (true);
		}
	}
		void OnTriggerEnter (Collider col) {
			if (No_More_Monster == false && enter1 == false) {
				porte.SetActive (true);
				porte1.SetActive (true);
				porte2.SetActive (true);
				Supermusic.SetActive (true);
				zobi2.SetActive (true);
				zobi1.SetActive (true);
				enter1 = true;
			}

		}

	
}
