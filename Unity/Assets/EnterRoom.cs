using UnityEngine;
using System.Collections;

public class EnterRoom : MonoBehaviour {

	public Transform point;

	void OnTriggerStay(Collider coll) {
		if(coll.name == "Player") {
			Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, point.position, Time.deltaTime * 2.0f);
			Camera.main.transform.rotation = Quaternion.Lerp(Camera.main.transform.rotation, point.rotation, Time.deltaTime * 2.0f);
		}
	}
}
