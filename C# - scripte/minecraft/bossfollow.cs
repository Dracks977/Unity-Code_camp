using UnityEngine;
using System.Collections;

public class bossfollow : MonoBehaviour {
	public GameObject player;
	private NavMeshAgent nav;
	public GameObject zobi;
	public bool follow = false;
	private Vector3 op;
	private float x;
	private float y;
	private float z;
	public bool onkack = false;

	// Use this for initialization
	void Start () {
		nav = zobi.GetComponent<NavMeshAgent> ();
	}

	// Update is called once per frame
	void Update () {
		Debug.DrawLine (player.transform.position, zobi.transform.position, Color.red);
		if (follow == true) {
			nav.Resume ();
			zobi.GetComponent<Animation> ().Play ("bosstourbilol");
			if (player.transform.position.x < zobi.transform.position.x)
				x = player.transform.position.x + 1;
			else
				x = player.transform.position.x - 1;
			if (player.transform.position.y < zobi.transform.position.y)
				y = player.transform.position.y + 1;
			else
				y = player.transform.position.y - 1;
			if (player.transform.position.z < zobi.transform.position.z)
				z = player.transform.position.z + 1;
			else
				z = player.transform.position.z - 1;
			//ternaire x y - ou -
			nav.SetDestination (new Vector3 (x, y, z));
			//creeper.transform.Rotate (new Vector3( (creeper.transform.rotation.x), player.transform.rotation.y, (creeper.transform.rotation.z)) );
		}
	}

	void OnTriggerEnter (Collider col) {
		if (col.gameObject.layer == 10) {
			nav.Resume ();
			follow = true;
		}
	}
	void OnTriggerExit (Collider col) {
		if (col.gameObject.layer == 10) {
			nav.Stop ();
			follow = false;
		}
	}

}
