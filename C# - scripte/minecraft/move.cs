using UnityEngine;
using System.Collections;

[RequireComponent (typeof(CharacterController))]

public class move : MonoBehaviour {

	public float walk = 6.0F;
	public float run = 10.0f;
	public float crouchSpeed = 4.0F;
	public float jumpSpeed = 8.0F;
	public float hyperJump = 25.0F;
	public float gravity = 20.0F;

	public bool isFreeze = false;

	//POTION
	public int potionCount;
	public bool potionActive = false;

	private Vector3 moveDirection = Vector3.zero;

	CharacterController controller;

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
	}

	// Update is called once per frame
	void Update () {

		if (controller.isGrounded)
		{
			//Feed moveDirection with input.
			if (Input.GetKey(KeyCode.LeftShift))
			{
				if (potionActive)
				{
					moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
					moveDirection = transform.TransformDirection(moveDirection);
					//Multiply it by run + potion.
					moveDirection *= run + 5;
				}
				else
				{
					moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
					moveDirection = transform.TransformDirection(moveDirection);
					//Multiply it by run.
					moveDirection *= run;
				}
			}
			else if(Input.GetKey(KeyCode.LeftControl))
			{
				moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
				moveDirection = transform.TransformDirection(moveDirection);
				//Multiply it by crouchSpeed.
				moveDirection *= crouchSpeed;
			}
			else
			{
				if (potionActive)
				{
					moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
					moveDirection = transform.TransformDirection(moveDirection);
					//Multiply it by walk + potion.
					moveDirection *= walk + 5;
				}
				else
				{
					moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
					moveDirection = transform.TransformDirection(moveDirection);
					//Multiply it by walk.
					moveDirection *= walk;
				}
			}


			//Jumping
			if (Input.GetButton("Jump"))
				moveDirection.y = jumpSpeed;
		}
		//Applying gravity to the controller
		moveDirection.y -= gravity * Time.deltaTime;
		//Making the character move
		if (isFreeze)
		{

		}
		else
		{
			controller.Move(moveDirection * Time.deltaTime);
		}

	}

	void OnGUI()
	{
		string msgFreeze;

		if (isFreeze)
		{
			msgFreeze = "UnFreeze";
		}
		else
		{
			msgFreeze = "Freeze";
		}


		if (GUI.Button(new Rect(10, 10, 100, 25), "Potion") && potionCount > 0)
		{
			StartCoroutine(PotionSpeed(10));
		}

		if (GUI.Button(new Rect(10, 40, 100, 25), "Hyper Jump"))
		{
			transform.Translate(new Vector3(0, hyperJump, 0));
		}

		if (GUI.Button(new Rect(10, 70, 100, 25), msgFreeze))
		{
			isFreeze =! isFreeze;
		}
	}

	IEnumerator PotionSpeed(int time)
	{
		potionCount--;
		potionActive = true;
		yield return new WaitForSeconds(time);
		potionActive = false;
	}
}