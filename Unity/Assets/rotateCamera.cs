using UnityEngine;
using System.Collections;

public class rotateCamera : MonoBehaviour {
	public GameObject futureCam;
	public string lastRoom = "";

	void Start() {
		futureCam = new GameObject ();
		futureCam.transform.position = Camera.main.transform.position;
		futureCam.transform.rotation = Camera.main.transform.rotation;
	}

	void Update() {
		Camera.main.transform.position = Vector3.Slerp(Camera.main.transform.position, futureCam.transform.position, Time.deltaTime * 2.0f);
		Camera.main.transform.rotation = Quaternion.Slerp(Camera.main.transform.rotation, futureCam.transform.rotation, Time.deltaTime * 2.0f);
	}
}
