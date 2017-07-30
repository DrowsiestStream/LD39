using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour 
{
	public Transform[] spawnPoints;

	public GameObject[] objectPrefabs;

	public float timeBetweenSpawns = 4f;

	public float timeToSpawn = 3f;

	// Use this for initialization
	void Update() 
	{
		if (Time.time >= timeToSpawn)
		{
			SpawnEntities();
			timeToSpawn = Time.time + timeBetweenSpawns;
		}
	}
	
	void SpawnEntities()
	{
		int randomIndex = Random.Range(0, spawnPoints.Length);

		for(int i = 0; i < spawnPoints.Length; i++)
		{
			if(randomIndex == i)
			{
				Instantiate(objectPrefabs[0], spawnPoints[i].position, Quaternion.identity);
			}
			else
			{
				Instantiate(objectPrefabs[1], spawnPoints[i].position, Quaternion.identity);
			}
		}
	}
}
