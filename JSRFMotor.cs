using UnityEngine;
using System.Collections;

[RequireComponent (typeof (CharacterController))]

public class JSRFMotor : MonoBehaviour {
	
	private float acceleration = 0.3f;
	private float currentSpeed = 14f;
	private float maxSpeed = 2f;
	private float rotationOnTurnInDeg = 75f;
	private float xAxisMovementReduction = 1f;//0.18f;
	
	void Start () {
	
	}
	
	void Update () {
		float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
		
		//Make sure the following is true:
		//inputX + inputY <= 1
		//Note: some irrelevant calculations to make more readable, optimise later
		if (inputX + inputY > 1) {
			float sum = inputX + inputY;
			float ratio = sum/1;
			inputX /= ratio;
			inputY /= ratio;
		}
		
		//Movement
		float xAxisMovement = inputX * xAxisMovementReduction;
		float zAxisMovement = inputY * currentSpeed;
		Vector3 moveDirection;
		
		//If only moving left or right we want to emphasise that the character is
		//skating in a circle so the movement on the x axis is maximised
		//Otherwise when moving forward and turning, the x axis movement is minimised
		//if (inputY == 0)
		//	moveDirection = new Vector3(inputX * currentSpeed, 0, 0) * Time.deltaTime;
		//else 
			moveDirection = new Vector3(xAxisMovement, 0, zAxisMovement) * Time.deltaTime;
		GetComponent<CharacterController>().Move(transform.TransformDirection(moveDirection));
		
		//Rotation
		float yAxisRotation = inputX * rotationOnTurnInDeg;
		transform.Rotate(new Vector3(0, yAxisRotation, 0) * Time.deltaTime);
	}
}
