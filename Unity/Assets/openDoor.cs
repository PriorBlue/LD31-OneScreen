using UnityEngine;
using System.Collections;

public class openDoor : MonoBehaviour {
	public int doorID = 0;
	public string animationName = "openDoor";
	public bool floor = true;
	private bool opened = false;
	
	void OnTriggerEnter(Collider coll) {
		if (!opened) {
			if (floor) {
				if (coll.gameObject.name != "Player" && coll.gameObject.name != "Pusher") {
					GameObject.Find ("Door" + doorID).animation.Play (animationName);
					opened = true;
				}
			} else {
				if (coll.gameObject.name == "Pusher") {
					GameObject.Find ("Door" + doorID).animation.Play (animationName);
					opened = true;
				}
			}
		}
	}
}
