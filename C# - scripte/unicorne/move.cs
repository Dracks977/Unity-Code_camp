using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	private Rigidbody2D rb;
	private Animator anim;
	public float jump = 30f;
	public float speed = 2f;
	public float maxSpeed = 30f;
	public float acceleration = 0.001f;
	public GameObject camera;
	public float Dashspeed = 500f;
	public int canjump = 0;
	public int candash = 0;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
		camera.SetActive (false);
	}

	void OnCollisionEnter2D (Collision2D coll){
		if (canjump != 1) {
			canjump++;
		}
		if (candash != 1) {
			candash++;
		}
	}
	
	// Update is called once per frame
	void Update () {
			
		if (speed < maxSpeed) {
			rb.velocity = new Vector3 (speed, rb.velocity.y);
			speed = speed + acceleration;
		}
		else
			rb.velocity = new Vector3 (speed, rb.velocity.y);
		
		if (Input.GetKey ("e") && candash != 0){
			anim.SetTrigger("Dash");
			rb.AddForce (Vector3.right * Dashspeed);
			candash--;
		} 
		if (Input.GetKeyDown ("space") && canjump != 0){
			canjump--;
			anim.SetTrigger("Jump");
			rb.velocity = new Vector3 (rb.velocity.x, jump);
		} 
}
}