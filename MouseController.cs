using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour 
{
	// Update is called once per frame
	void Update () 
	{
		if (transform.position.y < -3f)
		{
			Destroy(gameObject);
		}
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.name == "Cat")
		{
			Destroy(gameObject);
			GetAddPowerFunction();
		}
	}

	void GetAddPowerFunction()
	{
		FindObjectOfType<Power>().addPower();
	}
}
