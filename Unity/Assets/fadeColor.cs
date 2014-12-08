using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class fadeColor : MonoBehaviour {
	private Color currentColour;
	private float t;
	public Color color1 = new Color (0.0f, 0.0f, 0.0f, 1.0f);
	public Color color2 = new Color (1.0f, 1.0f, 1.0f, 1.0f);
	
	// Use this for initialization
	void Start () {
		GetComponent<Text>().color = color1;
	}
	
	void Update () {
		t += Time.deltaTime;

		if(currentColour == color1)
		{
			GetComponent<Text>().color = Color.Lerp(currentColour, color2, t);
			if(GetComponent<Text>().color == color2) {
				currentColour = color2;
				t = 0;
			}
		}
		else
		{
			GetComponent<Text>().color = Color.Lerp(currentColour, color1, t);
			if(GetComponent<Text>().color == color1) {
				currentColour = color1;
				t = 0;
			}
		}
	}
}