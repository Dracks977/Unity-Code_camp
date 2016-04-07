using UnityEngine;
using System.Collections;

public class unpause : MonoBehaviour {
	public GameObject pause;
	public GameObject pausui;
	public GameObject licorne;
	public GameObject cam2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			cam2.SetActive (false);
			pausui.SetActive (false);
			Time.timeScale = 1;
			pause.SetActive (true);
			this.gameObject.SetActive (false);
			licorne.SetActive (true);
		}
	}
}
