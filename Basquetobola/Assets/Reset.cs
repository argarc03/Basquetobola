using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour {

	public void ResetScene()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene(0);
	}
}
