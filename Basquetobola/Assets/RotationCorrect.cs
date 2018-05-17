using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCorrect : MonoBehaviour {

	public GameObject player;

	private float x, y;
	private Vector3 rotateValue;

	Vector3 offset;

	void Start()
	{
		offset = transform.position - player.transform.position;
	}

	// Update is called once per frame
	void Update () {

		transform.position = player.transform.position + offset;

		y = Input.GetAxis ("Mouse X");
		x = Input.GetAxis ("Mouse Y");

		rotateValue = new Vector3 (x,y*-1,0f);
		transform.eulerAngles = transform.eulerAngles - rotateValue;
	}
}
