using UnityEngine;
using System.Collections;

public class openDoor : MonoBehaviour {
	public int doorID = 0;
	public string animationName = "openDoor";

	void OnTriggerEnter(Collider coll) {
		Debug.Log (coll.gameObject.name);
		if(coll.gameObject.name != "Player" && coll.gameObject.name != "Pusher") {
			GameObject.Find ("Door" + doorID).animation.Play (animationName);
		}
	}
}
