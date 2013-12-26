using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Camera))]

public class JSRFArenaCamera : MonoBehaviour
{
	
	private Transform target;
	private float height = 25f;

	// Use this for initialization
	void Start ()
	{
		target = GameObject.FindGameObjectWithTag("Player").transform;
		
		transform.position = new Vector3(target.position.x, target.position.y + height, target.position.z);
		transform.LookAt(target.position);
	}
	
	// Update is called once per frame
	void Update ()
	{
	}
}

