using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Camera))]

public class JSRFCamera : MonoBehaviour
{
	
	private Transform target;
	private float distanceBehindTarget = 3f;
	private float height = 0.5f;
	private float distanceToLookAtInFrontOfTarget = 3f;

	// Use this for initialization
	void Start ()
	{
		target = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.position = target.position - (target.forward * distanceBehindTarget);
		transform.position = new Vector3(transform.position.x, transform.position.y + height, transform.position.z);
		transform.LookAt(target.position + (target.forward * distanceToLookAtInFrontOfTarget));
	}
}

