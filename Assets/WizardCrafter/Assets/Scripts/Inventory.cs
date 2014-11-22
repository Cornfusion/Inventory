using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {

	public GUISkin skin;

	public int slotsX;
	public int slotsY;
	public List<Item> inventory = new List<Item>();
	public List<Item> slots = new List<Item>();
	private bool showInventory;
	private ItemDatabase database;

	//Tooltips
	private bool showTooltip;
	private string tooltip;

	private bool draggingItem;
	private Item draggedItem;
	private int prevIndex;


	// Use this for initialization
	void Start () 
	{

		//Initialise each inventory slot with an empty item
		for(int i = 0; i < (slotsX * slotsY); ++i)
		{
			slots.Add (new Item());
			inventory.Add (new Item());
		}

		database = GameObject.FindGameObjectWithTag ("ItemDatabase").GetComponent<ItemDatabase>();



		//RemoveItem (1);

	}

	void Update()
	{
		if(Input.GetButtonDown("Inventory"))
		{
			showInventory = !showInventory;
			//showTooltip = false;
		}
	}

	void OnGUI()
	{
		tooltip = "";
		GUI.skin = skin;
		if(showInventory)
		{
			DrawInventory();
			
			if(showTooltip)
			{
				GUI.Box (new Rect(Event.current.mousePosition.x + 20, Event.current.mousePosition.y, 280, 64), tooltip, skin.GetStyle("Tooltip"));
			}
		}
		if(draggingItem)
		{
			GUI.DrawTexture(new Rect(Event.current.mousePosition.x, Event.current.mousePosition.y, 50, 50), draggedItem.itemIcon);
		}
	}

	void DrawInventory()
	{
		//Middle coords for inventory box
		float startX = Screen.width * 0.5f - 2 * 64;
		float startY = Screen.height * 0.9f;
		Event currentEvent = Event.current;
		int i = 0;
		for(int y = 0; y < slotsY; ++y)
		{
			for(int x = 0; x < slotsX; ++x)			
			{
				Rect slotRect = new Rect((startX + x*64), (startY + y*64), 64, 64);
				GUI.Box (slotRect, "", skin.GetStyle("Slot"));

				slots[i] = inventory[i];
				if(slots[i].itemID != null && slots[i].itemID != 0)
				{
					GUI.DrawTexture(slotRect, inventory[i].itemIcon);
					if(slotRect.Contains(Event.current.mousePosition))
					{

						tooltip = CreateTooptip(slots[i]);
						if(!draggingItem)
						{
							showTooltip = true;
						}
					
						if(currentEvent.button == 0 && currentEvent.type == EventType.mouseDrag && !draggingItem)
						{
							draggingItem = true;
							prevIndex = i;
							draggedItem = slots[i];
							inventory[i] = new Item();
						}
						//Right click to remove item
						if(currentEvent.button == 1 && !draggingItem)
						{

							inventory[i] = new Item();
						}
						if(currentEvent.type == EventType.mouseUp && draggingItem)
						{
							inventory[prevIndex] = inventory[i];
							inventory[i] = draggedItem;
							draggingItem = false;
							draggedItem = null;
						}

						if(currentEvent.isMouse && currentEvent.type == EventType.mouseDown && currentEvent.button == 1)
						{
							if(slots[i].itemType == Item.ItemType.Consumable)
							{
								print ("Used consumable");
							}
						}
					}

				}
				else
				{
					if(slotRect.Contains(Event.current.mousePosition))
					{
						if(currentEvent.type == EventType.mouseUp && draggingItem)
						{
							inventory[i] = draggedItem;
							draggingItem = false;
							draggedItem = null;
						}
					}


				}

				if(tooltip == "")
				{
					showTooltip = false;
				}



				++i;
			}
		}
	}

	string CreateTooptip(Item item)
	{

		tooltip = "<color=#FFFFFF>" + item.itemName + "</color>\n\n" +
						"<color=#D1D1D1>" + item.itemDesc + "</color>\n\n";
		return tooltip;
	}

	public void AddItem(int id)
	{
		for(int i = 0; i < inventory.Count; ++i)
		{
			if(inventory[i].itemName == null)
			{
				for(int j = 0 ; j < database.items.Count; ++j)
				{
					if(database.items[j].itemID == id)
					{						
						inventory[i] = database.items[j];
					}
				}
				break;
			}
		}
	}

	void RemoveItem(int id)
	{
		for(int i = 0; i < inventory.Count; ++i)
		{
			if(inventory[i].itemID == id)
			{
				inventory[i] = new Item();
				break;
			}
		}
	}

	public bool InventoryContains(int id)
	{
		for(int i = 0; i < inventory.Count; ++i)
		{
			//result = inventory[i].itemID == id;
			if(inventory[i].itemID == id)
			{
				return true;
			}
		}

		return false;
	}

	void OnTriggerEnter(Collider collider)
	{
		for(int i = 0; i < inventory.Count; ++i)
		{
			if(inventory[i].itemName == null)
			{
				if(collider.tag == "Item")
				{
					showInventory = true;
					int id = 0;
					id = collider.GetComponent<ItemID>().itemID;
					AddItem(id);
					Destroy(collider.gameObject);
					return;
				}
			}
		}
	}

}

