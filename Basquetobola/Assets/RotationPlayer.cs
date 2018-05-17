using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationPlayer : MonoBehaviour {

	private Vector3 rotateValue;
	private float x, y;

	// Update is called once per frame
	void Update () {

		y = Input.GetAxis ("Mouse X");
		x = Input.GetAxis ("Mouse Y");

		rotateValue = new Vector3 (0,y*-1,0f);
		transform.eulerAngles = transform.eulerAngles - rotateValue;
	}
}
