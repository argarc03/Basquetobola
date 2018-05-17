using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinZone : MonoBehaviour {

	public GameObject panelWin;


	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.CompareTag ("Player")) {
			Time.timeScale = 0;
			panelWin.SetActive (true);
			Cursor.visible = true;
		}
	}
}
