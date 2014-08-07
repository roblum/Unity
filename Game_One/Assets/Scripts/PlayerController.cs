using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("Hello World");
	}
	
	// Update is called once per frame
	void Update () {
		//Declare force
		Vector3 force;
		force = new Vector3(10f, 0, 0);
		//Instatiate force to a new instace of Vector3

		rigidbody.AddForce (force);

	}
}
