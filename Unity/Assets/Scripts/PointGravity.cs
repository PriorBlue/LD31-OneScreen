using UnityEngine;
using System.Collections;

public class PointGravity : MonoBehaviour {
	void OnTriggerStay (Collider other) {
		if (other.rigidbody && other.gameObject.tag == "Gravity")
		{
			other.rigidbody.useGravity = false;

			Vector3 direction = transform.position - other.transform.position;

			other.rigidbody.AddForce(direction * other.rigidbody.mass * 10.0f);

			if(other.gameObject.name == "Player") {
				other.transform.rotation = 
					Camera.main.GetComponent<rotateCamera>().futureCam.transform.rotation;
				other.transform.Rotate(270f,0f,0f);
			}
			other.transform.rotation =
				Quaternion.FromToRotation(-other.transform.up, direction) * other.transform.rotation;
		}
	}
}
