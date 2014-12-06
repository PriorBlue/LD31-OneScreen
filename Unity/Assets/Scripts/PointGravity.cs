using UnityEngine;
using System.Collections;

public class PointGravity : MonoBehaviour {
	void OnTriggerStay (Collider other) {
		other.attachedRigidbody.useGravity = false;
		
		var direction = -(other.attachedRigidbody.transform.position - transform.position);
		
		if (other.attachedRigidbody)
		{
			other.attachedRigidbody.constantForce.force = direction;
		}
	}
}
