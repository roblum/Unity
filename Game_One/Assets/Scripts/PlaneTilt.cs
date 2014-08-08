using UnityEngine;
using System.Collections;

public class PlaneTilt : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Quaternion delta = Quaternion.Euler (new Vector3 (0, 0, 10f) * Time.deltaTime);

		rigidbody.MoveRotation (rigidbody.rotation * delta);
	}
}
