using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

	public float mouseSensivity = 100f;
	public Transform Controller;
	private float xRotation = 0f;
	
	// Use this for initialization
	void Start ()
	{
		Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update ()
	{
		float mouseX = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime;
		float mouseY = Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime;

		xRotation -= mouseY;
		xRotation = Mathf.Clamp(xRotation, -90f, 90f);

		transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
		Controller.Rotate(Vector3.up * mouseX);
	}
}
