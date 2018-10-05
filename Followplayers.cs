using UnityEngine;

public class playermovement : MonoBehaviour {

	public Rigidbody rb;

	public float forwardForce = 2000f; 
	public float sideWaysForce = 500f;

	// We marked this as "Fixed" update because we 
	//are using it to mess with physics
	void FixedUpdate () {
	
		rb.AddForce (0,0,forwardForce * Time.deltaTime); //Add a force 

		if(Input.GetKey("d")){
			rb.AddForce(sideWaysForce * Time.deltaTime,0,0,ForceMode.VelocityChange);


		}

		if(Input.GetKey("a")){
			rb.AddForce(-sideWaysForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
			
			
		}

	}
}