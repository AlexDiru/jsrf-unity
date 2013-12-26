using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Camera))]

public class JSRFCamera : MonoBehaviour
{
	
	private Transform target = GameObject.FindGameObjectWithTag("Player").transform;
	private float distanceBehindTarget = 3f;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.position = target.position - (target.forward * distanceBehindTarget);
		transform.LookAt(target.position);
	}
}

