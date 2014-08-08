using UnityEngine;
using System.Collections;

public class HoopController : MonoBehaviour {

	public GameObject[] hoopParts;
	public Vector3[] positions;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player"){
			if (other.gameObject.rigidbody.velocity.y < 0){
				Debug.Log ("Score!");
				foreach(GameObject g in hoopParts){
					g.rigidbody.isKinematic = false;
					g.rigidbody.AddExplosionForce(100f, other.transform.position, 4f);
				}
			}
		}
	}
}
