using UnityEngine;
using System.Collections;

[RequireComponent (typeof (CharacterController))]

public class JSRFMotor : MonoBehaviour {
	
	private float acceleration = 0.3f;
	private float currentSpeed = 20f;
	private float maxSpeed = 2f;
	private float rotationOnTurnInDeg = 2f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
		
        // If both horizontal and vertical are used simultaneously, limit speed (if allowed), so the total doesn't exceed normal move speed
        //float inputModifyFactor = inputX != 0.0f && inputY != 0.0f ? .7071f : 1.0f;
		
		//inputX *= inputModifyFactor;
		//inputY *= inputModifyFactor;
		
		
		
		Vector3 moveDirection = new Vector3(inputX , 0, inputY ) * currentSpeed * Time.deltaTime;
		GetComponent<CharacterController>().Move(transform.TransformDirection(moveDirection));
		
		//Rotate
		//float yAxisRotation = inputX * Time.deltaTime * rotationOnTurnInDeg;
		//transform.rotation = new Quaternion(transform.rotation.x, (transform.rotation.y + yAxisRotation)%(2*Mathf.PI), transform.rotation.z, transform.rotation.w);
	}
}
