using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderScript : MonoBehaviour {

	public playerScript ps;


	// Use this for initialization
	void OnCollisionEnter(Collision colliderInfo)
	{
	if(colliderInfo.collider.tag=="Obastacles")
	{
			ps.enabled = false;
			FindObjectOfType<gameState>().gameEnd();


	}
	}
}
