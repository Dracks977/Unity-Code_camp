using UnityEngine;
using System.Collections;
using System.Collections.Generic; 
using System.Runtime.Serialization.Formatters.Binary; 
using System.IO;

public class scoremort : MonoBehaviour {

	public GameObject objWithScript;
	Score scriptRef;

	// Use this for initialization
	void Start () {
		scriptRef = objWithScript.GetComponent<Score>();
		if (!File.Exists("Unicore.txt"))
		{
			TextWriter tw = new StreamWriter("Unicore.txt");
			tw.WriteLine("0");
			tw.Close();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D coll){
		TextReader tr = new StreamReader("Unicore.txt");
		if (int.Parse(tr.ReadLine()) <= scriptRef.count) {
			tr.Close ();
			TextWriter tw = new StreamWriter("Unicore.txt");
			tw.WriteLine(scriptRef.count.ToString());
			tw.Close();
		} else {
			tr.Close ();
		}
	}
}
