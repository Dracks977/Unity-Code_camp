using UnityEngine;
using System.Collections;

public class zobideathtrigerporte : MonoBehaviour {
	public GameObject triger;
	public GameObject zobi1;
	public GameObject zobi2;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		if (zobi1.activeSelf == false && zobi2.activeSelf == false) {
			triger.GetComponent<triggerporte> ().No_More_Monster = true;
		}
	}
}
