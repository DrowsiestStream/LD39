using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragandDrop : MonoBehaviour 
{

	private bool isDragging;
	private Vector3 targetPos;
	
	// Use this for initialization
	void Start () 
	{
		isDragging = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(isDragging == true)
		{
			targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			this.transform.position = new Vector2(targetPos.x,targetPos.y);
		}
	}


	void OnMouseDown()
	{
		isDragging = true;
	}

	void OnMouseUp()
	{
		isDragging = false;
	}
}
