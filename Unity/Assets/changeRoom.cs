using UnityEngine;
using System.Collections;

public class changeRoom : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider coll) {
		if (coll.gameObject.name == "Capsule") {
			Debug.Log("trig");
			GameObject.Find("SphereCube").transform.Rotate(new Vector3(0,90,0));
		}
	}
}
