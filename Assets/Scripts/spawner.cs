using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour 
{
	public GameObject enemy;
	public float spawnTime = 2f;
	private long idCount = 0;
	public Transform[] path;
	public int speed;

	void Start ()
	{
		InvokeRepeating ("Spawn", 0.0f, spawnTime);
	}

	void Spawn ()
	{
		// Create an instance of the enemy prefab at the selected spawn point's position and rotation.
		enemy creep = Object.Instantiate(enemy, transform.position, transform.rotation).GetComponent<enemy>();

		//###
		creep.Initialize(idCount, 20.0f, speed, path);

		idCount++;

	}

}
