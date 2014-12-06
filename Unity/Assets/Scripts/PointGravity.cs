using UnityEngine;
using System.Collections;

public class PointGravity : MonoBehaviour {
	void OnTriggerStay (Collider other) {
		other.rigidbody.useGravity = false;
		
		var direction = transform.position - other.transform.position;
		
		if (other.rigidbody)
		{
			other.rigidbody.AddForce(direction * 10.0f);
			other.transform.rotation = Quaternion.LookRotation(direction.normalized) * Quaternion.Euler(new Vector3(270,0,0));
			//other.transform.rotation = Quaternion.
		}
	}
}
