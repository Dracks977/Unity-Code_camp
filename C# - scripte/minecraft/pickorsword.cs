/* Coded by Dracks - vanhem_n@etna-alternance.net*/
using UnityEngine;
using System.Collections;

public class pickorsword : MonoBehaviour {
	public GameObject photo1;
	public GameObject photo2;

	public GameObject pick;
	public GameObject sword;
	public GameObject nue;
	public string touch_pick = "1";
	public string touch_sword = "2";
	public string touch_nue = "3";
	public bool haveapick = false;

	// Use this for initialization
	void Start () {
		
	}

	void fpick(){
		photo2.SetActive (false);
		photo1.SetActive (true);
		nue.SetActive (false);
		pick.SetActive (false);
		sword.SetActive (true);
	}
	void fsword(){
		photo2.SetActive (true);
		photo1.SetActive (false);
		nue.SetActive (false);
		sword.SetActive (false);
		pick.SetActive (true);
	}
	void toutnue(){
		photo2.SetActive (false);
		photo1.SetActive (false);
		nue.SetActive (true);
		sword.SetActive (false);
		pick.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (touch_pick)) {
			fpick();
		}
		if (Input.GetKey (touch_sword) && haveapick == true) {
			fsword();
		}
		if (Input.GetKey (touch_nue)) {
			toutnue ();
		}

	}
}
