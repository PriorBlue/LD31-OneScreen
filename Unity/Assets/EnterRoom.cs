using UnityEngine;
using System.Collections;

public class EnterRoom : MonoBehaviour {
	public Transform point;
	public Transform lastCam;
	
	void OnTriggerEnter(Collider coll) {
		if (coll.name == "Player") {
			Camera.main.GetComponent<rotateCamera> ().futureCam.transform.position = point.transform.position;
			
			if(Camera.main.GetComponent<rotateCamera> ().lastRoom != "" && Camera.main.GetComponent<rotateCamera> ().lastRoom != name) {
				Vector3 oPos = Camera.main.WorldToScreenPoint (coll.transform.position);
				float dx = Mathf.Abs(oPos.x - Screen.width * 0.5f);
				float dy = Mathf.Abs(oPos.y - Screen.height * 0.5f);
				
				if(dx < dy) {
					if (oPos.y > Screen.height * 0.5f) {
						Camera.main.GetComponent<rotateCamera> ().futureCam.transform.Rotate (90f, 0f, 0f);
					} else if (oPos.y < Screen.height * 0.5f) {
						Camera.main.GetComponent<rotateCamera> ().futureCam.transform.Rotate (-90f, 0f, 0f);
					}
				}else{
					if (oPos.x < Screen.width * 0.5f) {
						Camera.main.GetComponent<rotateCamera> ().futureCam.transform.Rotate (0f, 90f, 0f);
					} else if (oPos.x > Screen.width * 0.5f) {
						Camera.main.GetComponent<rotateCamera> ().futureCam.transform.Rotate (0f, -90f, 0f);
					}
				}
			}
			Camera.main.GetComponent<rotateCamera> ().lastRoom = name;
		}
	}
}
