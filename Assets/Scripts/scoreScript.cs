using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class scoreScript : MonoBehaviour {

	public Transform player;
	Vector3 initialPos;
	public float distance;
	public Text score;

	void Start()
	{
		initialPos = player.position;
	}
	// Update is called once per frame
	void Update () {

	distance =	Mathf.Abs(initialPos.z-player.position.z);	
	score.text=distance.ToString("0");
	}
}
