using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class playerScript : MonoBehaviour {


    // Use this for initialization
    public float forwardForce = 1000f;
    public float sideForce = 500f;
   	public Rigidbody rb;
	void Start () {


       
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		//rb.AddForce(0,0,forwardForce*Time.deltaTime);
		rb.AddForce(0,0,forwardForce*Time.deltaTime);
		if(Input.GetKey("d"))
		{
			rb.AddForce(sideForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
		}


	/*	if(Input.GetKey("w"))
		{
			rb.AddForce(0,0,forwardForce*Time.deltaTime);
		}


		if(Input.GetKey("s"))
		{
			rb.AddForce(0,0,-forwardForce*Time.deltaTime);
		}*/
		if(Input.GetKey("a"))
		{
			rb.AddForce(-sideForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
		}

		if(rb.position.y <-0.25)
			{
				FindObjectOfType<gameState>().gameEnd();
				this.enabled= false;
			}
	
		
	}
}
