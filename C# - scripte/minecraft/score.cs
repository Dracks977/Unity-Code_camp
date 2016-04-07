using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class score : MonoBehaviour {
	public Text Textscore;
	public int Totalscore = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Textscore.text = "X " + Totalscore.ToString ();
	}
}
