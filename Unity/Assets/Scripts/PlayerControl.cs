using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey (KeyCode.W)) {
			rigidbody.AddForce(transform.forward * 50f);
		}
		else if (Input.GetKey (KeyCode.S)) {
			rigidbody.AddForce(transform.forward * -50f);
		}
		if (Input.GetKey (KeyCode.A)) {
			rigidbody.AddForce(transform.right * -50f);
		}
		else if (Input.GetKey (KeyCode.D)) {
			rigidbody.AddForce(transform.right * 50f);
		}
	}
}
