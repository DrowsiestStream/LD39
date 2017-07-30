using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBottleController : MonoBehaviour 
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
			GetReducePowerFunction();
			Destroy(gameObject);
		}
	}

	void GetReducePowerFunction()
	{
		FindObjectOfType<Power>().reducePower();
	}
}
