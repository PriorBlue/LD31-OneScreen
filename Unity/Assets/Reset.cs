using UnityEngine;
using System.Collections;

public class Reset : MonoBehaviour {
	public void ResetGame () {
		Application.LoadLevel(Application.loadedLevel);
	}
}
