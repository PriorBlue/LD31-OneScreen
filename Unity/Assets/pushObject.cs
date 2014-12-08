using UnityEngine;
using System.Collections;

public class pushObject : MonoBehaviour {
	void OnTriggerStay (Collider other) {
		if (other.rigidbody && other.gameObject.tag == "Gravity" && other.gameObject.name != "Player") {
			other.rigidbody.AddForce(transform.forward * 7500.0f);
		}
	}
}
