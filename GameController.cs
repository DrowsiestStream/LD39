using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour 
{
	void Update()
	{
		if(FindObjectOfType<Power>().currentPower <= 0)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}

		if(Input.GetKey("escape"))
		{
			Application.Quit();
		}
	}
}