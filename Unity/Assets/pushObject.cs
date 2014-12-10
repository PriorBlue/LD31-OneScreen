using UnityEngine;
using System.Collections;

public class pushObject : MonoBehaviour {
    // maxPushAngle can be set to private once a good value is found
    public float maxPushAngle = 55f;
    Vector3 otherToPlayer = new Vector3(0,0,0);
	void OnTriggerStay (Collider other) {
		if (other.rigidbody && other.gameObject.tag == "Gravity" && other.gameObject.name != "Player") {
            otherToPlayer = other.transform.position - transform.position;
            // Enable the line below for testing:
            //Debug.Log("Angle:"+Vector3.Angle(transform.forward, otherToPlayer));
            if (Vector3.Angle(Vector3.Normalize(7*transform.forward-3*transform.up), otherToPlayer) < maxPushAngle)
            {
                other.rigidbody.AddForce(transform.forward * 7500.0f);
            }
		}
	}
}
