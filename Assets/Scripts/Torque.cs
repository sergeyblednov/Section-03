using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torque : MonoBehaviour {

	public Vector3 torque;
	public float torgueTime;

	Rigidbody rigidBody;

	void Start () {
		rigidBody = GetComponent <Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (torgueTime >= 0f) {
			torgueTime -= Time.deltaTime;
			rigidBody.AddTorque (torque);
		}
	}
}
