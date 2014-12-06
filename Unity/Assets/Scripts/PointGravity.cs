using UnityEngine;
using System.Collections;

public class PointGravity : MonoBehaviour {
	public Transform gravitySource;
	public float gravScalar = 4.0f;
	public Vector3 rotOffset = Vector3.zero;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		var direction = gravitySource.position - transform.position;
		rigidbody.AddForce(direction.normalized * gravScalar);
		transform.rotation = Quaternion.LookRotation(direction.normalized) * Quaternion.Euler(rotOffset);
		if (Input.GetKey (KeyCode.W)) {
			rigidbody.AddForce(transform.forward * 5f);
		}
		else if (Input.GetKey (KeyCode.S)) {
			rigidbody.AddForce(transform.forward * -5f);
		}
		if (Input.GetKey (KeyCode.A)) {
			rigidbody.AddForce(transform.right * -5f);
		}
		else if (Input.GetKey (KeyCode.D)) {
			rigidbody.AddForce(transform.right * 5f);
		}
	}
}
