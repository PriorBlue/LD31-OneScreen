using UnityEngine;
using System.Collections;

public class openDoor : MonoBehaviour {
	public string doorID = "";
	public string animationName = "openDoor";
	public bool floor = true;
	public GameObject secondTrigger = null;
	private bool opened = false;
	public GameObject[] Amazing;
	
	void OnTriggerEnter(Collider coll) {
		if (!opened) {
			if (floor) {
				if (coll.gameObject.tag == "Gravity" && coll.gameObject.name != "Player" && coll.gameObject.name != "Pusher") {
					if(secondTrigger == null || secondTrigger.GetComponent<openDoor>().opened) {
						GameObject.Find (doorID).animation.Play (animationName);
						if(Amazing.Length >= 1) {
							foreach(GameObject a in Amazing) {
								a.SetActive(true);
							}
						}
					}
					opened = true;
					renderer.material.color = new Color(0f,1f,0f);
					coll.gameObject.renderer.material.color = new Color(0f,1f,0f);
				}
			} else {
				if (coll.gameObject.name == "Pusher") {
					if(secondTrigger == null || secondTrigger.GetComponent<openDoor>().opened) {
						GameObject.Find (doorID).animation.Play (animationName);
						if(Amazing.Length >= 1) {
							foreach(GameObject a in Amazing) {
								a.SetActive(true);
							}
						}
					}
					opened = true;
					renderer.material.color = new Color(0f,1f,0f);
				}
			}
		}
	}
}
