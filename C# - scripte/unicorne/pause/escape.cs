using UnityEngine;
using System.Collections;

public class escape : MonoBehaviour {
	// Use this for initialization
	public GameObject unpause;
	public GameObject pausui;
	public GameObject licorne;
	public GameObject cam2;

	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.Escape)) {
			cam2.SetActive (true);
			licorne.SetActive (false);
			Time.timeScale = 0;
			unpause.SetActive (true);
			pausui.SetActive (true);
			this.gameObject.SetActive (false);

		}
	}
}
