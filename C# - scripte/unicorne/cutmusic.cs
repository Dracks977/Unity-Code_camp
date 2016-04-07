using UnityEngine;
using System.Collections;

public class cutmusic : MonoBehaviour {
	public AudioSource audio;
	public GameObject onoff;
	public GameObject offfff;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void musicstop(){
			audio.Stop();
		onoff.SetActive (false);
		offfff.SetActive (true);
	}
	public void startmusic(){
		audio.Play ();
		onoff.SetActive (true);
		offfff.SetActive (false);
	}

}
