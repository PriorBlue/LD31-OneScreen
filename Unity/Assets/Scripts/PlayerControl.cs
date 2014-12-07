using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	public Transform oldPointer;
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey (KeyCode.W)) {
			rigidbody.AddForce(transform.forward * 20f);
		}
		else if (Input.GetKey (KeyCode.S)) {
			rigidbody.AddForce(transform.forward * -20f);
		}
		if (Input.GetKey (KeyCode.A)) {
			rigidbody.AddForce(transform.right * -20f);
		}
		else if (Input.GetKey (KeyCode.D)) {
			rigidbody.AddForce(transform.right * 20f);
		}
	}
}
