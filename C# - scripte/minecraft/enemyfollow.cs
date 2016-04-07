using UnityEngine;
using System.Collections;

public class enemyfollow : MonoBehaviour {
	public GameObject player;
	private NavMeshAgent nav;
	public GameObject creeper;
	public bool follow = false;
	private Vector3 op;
	private float x;
	private float y;
	private float z;
	public bool onkack = false;


	// Use this for initialization
	void Start () {
		nav = creeper.GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.DrawLine (player.transform.position, creeper.transform.position, Color.blue);
		if (follow == true) {
				nav.Resume ();
				creeper.GetComponent<Animation> ().Play ("creeper");
			if (player.transform.position.x < creeper.transform.position.x)
				x = player.transform.position.x + 1;
			else
				x = player.transform.position.x - 1;
			if (player.transform.position.y < creeper.transform.position.y)
				y = player.transform.position.y + 1;
			else
				y = player.transform.position.y - 1;
			if (player.transform.position.z < creeper.transform.position.z)
				z = player.transform.position.z + 1;
			else
				z = player.transform.position.z - 1;
			//ternaire x y - ou -
			nav.SetDestination (new Vector3 (x, y, z));
			//creeper.transform.Rotate (new Vector3( (creeper.transform.rotation.x), player.transform.rotation.y, (creeper.transform.rotation.z)) );

		} else if (onkack == true){
			nav.Stop();
			creeper.GetComponent<Animation> ().Play("boom");
		} else {
			nav.Stop();
			creeper.GetComponent<Animation> ().Play("lcreeper");
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
