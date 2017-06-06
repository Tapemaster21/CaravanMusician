using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour 
{

	public Rigidbody self;
	public float speed;
	public Vector3 dir;

	void Start ()
	{
		//somehow get self
		//dir = new Vector3(0,1,0);
	}

	void FixedUpdate ()
	{
		//This is constant speed
		transform.Translate(dir * Time.deltaTime * speed);
	}

	void Message(Vector3 vec)
	{
		//Debug.Log(vec);
		//dir = vec;
		transform.Rotate(vec);
	}
}