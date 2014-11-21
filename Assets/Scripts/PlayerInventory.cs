using UnityEngine;
using System.Collections;

public class PlayerInventory : MonoBehaviour {

	//Array to store items
	public GameObject[] inventory;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown (KeyCode.I))
		{
			PrintInventory();
		}
	}

	void OnTriggerEnter(Collider collider)
	{
		Debug.Log (collider);
		if(collider.tag == "Item")
		{
			inventory[0] = collider.gameObject;
		}
	}

	void PrintInventory()
	{
		Debug.Log ("INVENTORY");
		int itemCount = 0;
		foreach (GameObject item in inventory)
		{
			++itemCount;
			Debug.Log ("Slot " + itemCount + " " + item.name + "\n");
		}

	}
}
