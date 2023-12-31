using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTypes : MonoBehaviour {

	private Rigidbody2D RigidBodycharacter;
	private GameObject character;

	void Start() {

		RigidBodycharacter = GetComponent<Rigidbody2D> ();

	}

	void Update () {

		///Move without Rigidbody
		character.transform.Translate (Vector2.up/300);

		///Move with Physics Forces
		RigidBodycharacter.AddForce (new Vector2 (0, 100));
		RigidBodycharacter.AddForce(transform.right * 5);

		///Move ignoring Physics
		RigidBodycharacter.velocity = new Vector2 (10, RigidBodycharacter.velocity.y);
		RigidBodycharacter.velocity = transform.right*2;
	}
}
