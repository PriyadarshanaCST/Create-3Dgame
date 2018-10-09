using UnityEngine;

public class playerCollosion : MonoBehaviour {

	public playermovement movement;

	void OnCollisionEnter (Collision collisionInfo){

		if (collisionInfo.collider.tag == "obstacle") {
		
			movement.enabled = false;
		}
	}
}