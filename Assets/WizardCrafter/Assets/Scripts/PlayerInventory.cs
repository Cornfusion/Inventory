using UnityEngine;
using System.Collections;

public class PlayerInventory : MonoBehaviour {

	//public Inventory inventory;

	// Use this for initialization
	void Start () 
	{
		//inventory = GameObject.FindGameObjectWithTag ("Inventory").GetComponent<Inventory>();
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	//void OnTriggerEnter(Collider collider)
	//{
	//	if(collider.tag == "Item")
	//	{
	//		int id = 0;
	//		Debug.Log (id);
	//		id = collider.GetComponent<ItemID>().itemID;
	//		Debug.Log (id);
	//		inventory.AddItem(id);
	//	}
	//}
}
