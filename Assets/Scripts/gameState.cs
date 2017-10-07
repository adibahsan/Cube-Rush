using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameState : MonoBehaviour {

	public bool isEnded = false;
	public GameObject levelCompleteUI;
	public GameObject gameOverUI;
	public Text gameScore;

	public void levelEnd()
	{
		
		Debug.Log("Level Completed!!");

		levelCompleteUI.SetActive(true);
		isEnded = true;


	}

	public void gameEnd()
	{
		if(!isEnded)
		{
			Debug.Log("Game Over");

	
			isEnded =true;
			gameOverUI.SetActive(true);
			gameScore.text = FindObjectOfType<scoreScript>().distance.ToString("0");
			//Invoke("Restart" ,2.5f);
		}

	}


	void Restart()
	{
		
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	
	}
}
