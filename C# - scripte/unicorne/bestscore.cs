using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic; 
using System.Runtime.Serialization.Formatters.Binary; 
using System.IO;

public class bestscore : MonoBehaviour {

	public Text best;
	private int count;
	// Use this for initialization
	void Start () {
		TextReader tr = new StreamReader("Unicore.txt");
		count = int.Parse (tr.ReadLine ());
		best.text = "Best: " + count.ToString ();
		tr.Close ();
	}

	// Update is called once per frame
	void Update () {

	}
}
