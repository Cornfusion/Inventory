using UnityEngine;
using System.Collections;

public class ItemSpawner : MonoBehaviour {


	
	//private ItemDatabase database;



	//ITEM PARAMETERS
	//Arrays to store items
	public GameObject[] commonItems;
	public GameObject[] uncommonItems;
	public GameObject[] rareItems;

	public int maxNoItems;
	private int currentNoItems;
	private int itemNumber;
	private int itemRarity;
	private Vector3 spawnPosition;


	//MAP PARAMETERS
	//Size of the map (Area items can spawn in)
	public int mapSize = 100;	


	// Use this for initialization
	void Start () 
	{
		//Set database to a database in the scene (This should be prefilled when it is constructed)
		//database = GameObject.FindGameObjectWithTag ("ItemDatabase").GetComponent<ItemDatabase>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown (KeyCode.Space))
		{
			SpawnRandomItem();
		}
	}

	void SpawnRandomItem()
	{		
		//Generate random item rarity
		itemRarity = Random.Range (0, 100);

		//If its a rare item pick a random item of that rarity
		if(itemRarity > 94)
		{
			itemNumber = Random.Range (0, commonItems.Length);
			SpawnCommonItem (itemNumber);
		}
		//If its an Uncommon item pick a random item of that rarity
		else if(itemRarity > 80 && itemRarity < 95)
		{
			itemNumber = Random.Range (0, commonItems.Length);
			
			SpawnCommonItem (itemNumber);
		}
		//Otherwise spawn a common item
		else
		{
			itemNumber = Random.Range (0, commonItems.Length);
			
			SpawnCommonItem (itemNumber);
		}
	}

	void SpawnCommonItem(int itemNumber)
	{
		//Create item and store it as tempItem
		GameObject tempItem = Instantiate (commonItems[itemNumber]) as GameObject;

		//Generate item position and other parameters
		//Generate and set item position to a random point on the map
		spawnPosition = Random.insideUnitCircle * mapSize;
		//Convert the x,y coords to x,z
		spawnPosition.z = spawnPosition.y;
		//Do a raycast down towards the terrain to find the Y position of the item
		spawnPosition.y = 2;
		tempItem.transform.position = spawnPosition;

		Debug.Log ("Common item " + itemNumber + "spawned at " + spawnPosition);

	}

	void SpawnUncommonItem(int itemNumber)
	{
		//Create item and store it as tempItem
		GameObject tempItem = Instantiate (uncommonItems[itemNumber]) as GameObject;
		
		//Generate item position and other parameters
		//Generate and set item position to a random point on the map
		spawnPosition = Random.insideUnitCircle * mapSize;
		//Convert the x,y coords to x,z
		spawnPosition.z = spawnPosition.y;
		//Do a raycast down towards the terrain to find the Y position of the item
		spawnPosition.y = 2;
		tempItem.transform.position = spawnPosition;
		
		Debug.Log ("Uncommon item " + itemNumber + "spawned at " + spawnPosition);
		
	}

	void SpawnRareItem(int itemNumber)
	{
		//Create item and store it as tempItem
		GameObject tempItem = Instantiate (rareItems[itemNumber]) as GameObject;
		
		//Generate item position and other parameters
		//Generate and set item position to a random point on the map
		spawnPosition = Random.insideUnitCircle * mapSize;
		//Convert the x,y coords to x,z
		spawnPosition.z = spawnPosition.y;
		//Do a raycast down towards the terrain to find the Y position of the item
		spawnPosition.y = 2;
		tempItem.transform.position = spawnPosition;
		
		Debug.Log ("Rare item " + itemNumber + "spawned at " + spawnPosition);
		
	}
}
