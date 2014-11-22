using UnityEngine;
using System.Collections;

public class TimedLife : MonoBehaviour {

	public float timedLife;

	// Use this for initialization
	void Start () {

		Destroy (gameObject, 1.5f);
	
	}
}
