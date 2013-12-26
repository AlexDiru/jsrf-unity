using UnityEngine;
using System.Collections;

public class JSRFX360ControllerTest : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		DetectJoystickNames();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetAxis("Horizontal") > 0)
			Debug.Log("Axis X");
		if (Input.GetAxis("Vertical") > 0)
			Debug.Log("Axis Y");
	}
	
	private void DetectJoystickNames()
	{
		int i = 1;
		foreach (string name in Input.GetJoystickNames())
			Debug.Log((i++) + ": " + name);
	}
}

