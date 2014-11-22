using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float moveSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void FixedUpdate()
	{
		if(Input.GetKey(KeyCode.A))
		{
			MoveLeft ();
		}
		else if(Input.GetKey(KeyCode.D))
		{
			MoveRight ();
		}
		if(Input.GetKey(KeyCode.W))
		{
			MoveUp ();
		}
		else if(Input.GetKey(KeyCode.S))
		{
			MoveDown ();
		}
	}

	void MoveLeft()
	{
		transform.rigidbody.velocity -= new Vector3 (moveSpeed, 0, 0) * Time.deltaTime;
	}
	void MoveRight()
	{
		transform.rigidbody.velocity += new Vector3 (moveSpeed, 0, 0) * Time.deltaTime;
	}
	void MoveUp()
	{
		transform.rigidbody.velocity += new Vector3 (0, 0, moveSpeed) * Time.deltaTime;
	}
	void MoveDown()
	{
		transform.rigidbody.velocity -= new Vector3 (0, 0, moveSpeed) * Time.deltaTime;
	}
}
