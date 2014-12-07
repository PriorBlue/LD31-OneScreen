using UnityEngine;
using System.Collections;

public class QuaternionTest : MonoBehaviour {
	Quaternion q1;
	Quaternion q2;

	void Start(){
		q1=new Quaternion (1, 1, 1, 1);
		q2=new Quaternion (2, 1, 1, 1);
	}

	void FixedUpdate(){
		Debug.LogError (Quaternion.Dot (q1, q2));
	}
}

/*{

}*/