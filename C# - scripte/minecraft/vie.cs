/*coded by Dracks*/
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class vie : MonoBehaviour {
	public GameObject vie1;
	public GameObject vie2;
	public GameObject vie3;
	public GameObject vie4;
	public GameObject vie5;
	public int Pvie = 5;
	public float timervie;
	private bool timefirst = true;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Pvie != 5 && timefirst == true) {
			timervie = (Time.time + 25f);
			timefirst = false;
		}
		if (Pvie != 5 && timervie <= Time.time) {
			timervie = (Time.time + 15f);
			Pvie++;
		}
		if (Pvie == 5) {
			vie1.SetActive (true);
			vie2.SetActive (true);
			vie3.SetActive (true);
			vie4.SetActive (true);
			vie5.SetActive (true);
		} else if (Pvie == 4) {
			vie1.SetActive (false);
			vie2.SetActive (true);
			vie3.SetActive (true);
			vie4.SetActive (true);
			vie5.SetActive (true);
		} else if (Pvie == 3) {
			vie1.SetActive (false);
			vie2.SetActive (false);
			vie3.SetActive (true);
			vie4.SetActive (true);
			vie5.SetActive (true);
		} else if (Pvie == 2) {
			vie1.SetActive (false);
			vie2.SetActive (false);
			vie3.SetActive (false);
			vie4.SetActive (true);
			vie5.SetActive (true);
		} else if (Pvie == 1) {
			vie1.SetActive (false);
			vie2.SetActive (false);
			vie3.SetActive (false);
			vie4.SetActive (false);
			vie5.SetActive (true);
		} else {
			//menu mort ici
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}
}
