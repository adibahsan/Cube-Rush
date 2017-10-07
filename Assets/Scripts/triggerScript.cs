using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerScript : MonoBehaviour {

	void OnTriggerEnter(Collider triggerInfo)
	{
		if(triggerInfo.tag=="Player")
		{

			FindObjectOfType<gameState>().levelEnd();
		}

	}
}
