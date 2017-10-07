using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelChange : MonoBehaviour {

	
	// Use this for initialization
	public void NextLevel()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
		FindObjectOfType<gameState>().isEnded=true;
	}

	public void Restart()
	{
		
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
