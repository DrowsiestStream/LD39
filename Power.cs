using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour 
{

	public float maxPower;
	public float currentPower;

	 public float powerUsage = 1;
	// Use this for initialization
	void Start () 
	{
		currentPower = maxPower;
	}
	
	// Update is called once per frame
	void Update () 
	{
		currentPower = currentPower - powerUsage * Time.deltaTime;
		transform.localScale = new Vector3((currentPower / maxPower), 1, 1);

		if(currentPower <= 0)
		{
			currentPower = 0;
		}

		powerUsage = Mathf.Lerp(1, 6, Time.time * 0.01f);
	}

	public void addPower()
	{
		if (currentPower +5 >= 100)
		{
			currentPower = 100;
		}
		else
		{
			currentPower += 5;
		}
		
	}

	public void reducePower()
	{
		if (currentPower -5 <= 0)
		{
			currentPower = 0;
		}
		else
		{
			currentPower -= 5;
		}
		
	}
}
