using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {
	public GameObject tempPlayer;
	void Start () {
		tempPlayer = GameObject.Find ("Player");
		tempPlayer.SetActive (false);
	}

	public void startGame() {
		tempPlayer.SetActive (true);
	}
}
