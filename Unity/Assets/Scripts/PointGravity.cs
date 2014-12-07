using UnityEngine;
using System.Collections;

public class PointGravity : MonoBehaviour {
	void OnTriggerStay (Collider other) {
		if (other.rigidbody && other.gameObject.tag == "Gravity")
		{
			other.rigidbody.useGravity = false;

			Vector3 direction = transform.position - other.transform.position;
			float dist = Vector3.Distance(other.transform.position, transform.position);

			if(dist >= 6.0f) {
				other.rigidbody.AddForce(direction * 10.0f);
			}
			other.transform.rotation = Quaternion.FromToRotation(-other.transform.up, direction.normalized) * other.transform.rotation;
		}
	}
}
