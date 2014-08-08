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
				//force = new Vector3(1000f, 0, 0);
				//Instatiate force to a new instace of Vector3

				force = new Vector3 (0, 0, 0);

				if (Input.GetKey (KeyCode.RightArrow)) { //Run when right arrow pressed
						force.x += 1000f;
				} else if (Input.GetKey (KeyCode.LeftArrow)) {
						force.x -= 1000f;				
				} else if (Input.GetKey (KeyCode.UpArrow)) {
						force.y += 1000f;		
				} else if (Input.GetKey (KeyCode.DownArrow)) {
						force.y -= 1000f;
				}

				force = force * Time.deltaTime;
				rigidbody.AddForce (force);
				//Force moves object with physics; Transform teleports object

	}
}
