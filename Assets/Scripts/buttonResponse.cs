using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonResponse : MonoBehaviour {

	public void appQuit()
	{
		Debug.Log("Quit");
		Application.Quit();

	}

	public void LoadApp()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

	}
}
