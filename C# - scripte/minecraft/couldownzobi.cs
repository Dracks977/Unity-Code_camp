using UnityEngine;
using System.Collections;

public class couldownzobi : MonoBehaviour {
	public GameObject bra1;
	public float timerboum;
	// Use this for initialization
	void Start () {
		timerboum = 0f;
	}
	
	// Update is called once per frame
	void Update () {

		if (timerboum <= Time.time) {
			bra1.SetActive (true);
			timerboum = Time.time + 0.8f;
		} else {
			bra1.SetActive (false);

		}
			
	}
}
