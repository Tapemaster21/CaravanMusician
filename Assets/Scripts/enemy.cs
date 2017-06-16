using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour 
{
	long id;
	public Rigidbody self;
	public float speed;
	public Vector3 dir;
	public float health;
	private float maxHealth;
	public Transform[] path;
	private Color blendColor;
	public Gradient gradient;

	private int nextTarget;


	public void Initialize(long id, float health, float speed, Transform[] path)
	{
		this.health = health;
		this.maxHealth = health;
		this.id = id;
		this.speed = speed;
		this.path = path;

		dir = transform.forward;
		transform.LookAt(path[0]);
	}


	void Start ()
	{
		
	}

	void FixedUpdate ()
	{
		//am i dead
		if(health <=0){
			Destroy (this.GetComponent<enemy>().gameObject);
		}

		blendColor = gradient.Evaluate (health / maxHealth);
		Debug.Log (health / maxHealth);



		//set color in respect to healths
		//blendColor = Color.Lerp (Color.white, Color.black, health/maxHealth);
		this.GetComponent<Renderer> ().material.color = blendColor;


		Vector3 target = this.path[nextTarget].transform.position;
		target = new Vector3(target.x, this.transform.position.y, target.z);
		


		//change direction
		if((transform.position - target).magnitude < 0.2)
		{
			nextTarget++;
			Debug.Log ("ID" + this.id + " : " + nextTarget);

			transform.LookAt (path [nextTarget]);
		}
		//This is constant speed
		transform.Translate(dir * Time.deltaTime * speed);


	}

	void Turn(Vector3 vec)
	{
		//Debug.Log(vec);
		//dir = vec;
		transform.Rotate(vec);
	}

	public void TakeDamage(long dmg)
	{
		Debug.Log (health + " - " + dmg);
		health = health - dmg;

	}
}