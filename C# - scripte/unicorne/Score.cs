using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {
	public Text countText;
	public int count;
	// Use this for initialization
	void Start () {
		count = 0;
		SetCountText ();
	}
	
	// Update is called once per frame
	void Update () {
		SetCountText ();
	}

	void OnCollisionEnter2D(Collision2D coll){

		if (coll.gameObject.layer == 21) {
			Destroy (coll.gameObject);
			count = count + 1;
		}
	}

	void SetCountText ()
	{
		countText.text = "Score: " + count.ToString ();
	}
}
