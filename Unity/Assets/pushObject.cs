using UnityEngine;
using System.Collections;

public class pushObject : MonoBehaviour {
	void OnTriggerStay (Collider other) {
		if (other.rigidbody && other.gameObject.tag == "Gravity" && other.gameObject.tag != "Player") {
			other.rigidbody.AddForce(transform.forward * 3000.0f);
		}
	}
}
