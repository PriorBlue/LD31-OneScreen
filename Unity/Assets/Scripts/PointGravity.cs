using UnityEngine;
using System.Collections;

public class PointGravity : MonoBehaviour {
	public Vector3 rotOffset = Vector3.zero;

	void OnTriggerStay (Collider other) {
		other.rigidbody.useGravity = false;
		
		Vector3 direction = transform.position - other.transform.position;
		float dist = Vector3.Distance(other.transform.position, transform.position);
		
		if (other.rigidbody && other.gameObject.tag == "Gravity")
		{
			if(dist >= 6.0f) {
				other.rigidbody.AddForce(direction * 10.0f);
			} else {
				//other.rigidbody.AddForce(direction * -1.0f);
			}
			//other.rigidbody.velocity = direction * 0.001f;
			//other.transform.rotation = Quaternion.LookRotation(direction.normalized) * Quaternion.Euler(rotOffset);
			other.transform.rotation = Quaternion.FromToRotation(-other.transform.up, direction.normalized) * other.transform.rotation;
		}
	}
}
