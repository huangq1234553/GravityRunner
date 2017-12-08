using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


	public float runSpeed;
	public float changeSpeed;
	public float jumpPower;
	Rigidbody2D rigidBody;
	bool isGrounded = false;
	public float hight;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (((Vector2.right * runSpeed) + (Vector2.right * runSpeed)*Input.GetAxis("Horizontal") * changeSpeed)*Time.deltaTime);

		if (Physics2D.Raycast(transform.position, Vector2.down, hight)) {
			print ("there is something there");
			rigidBody.AddForce (Vector2.up * jumpPower * Input.GetAxis("Jump"));
		}
	}

}
