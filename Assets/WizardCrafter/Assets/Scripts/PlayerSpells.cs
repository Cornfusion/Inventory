using UnityEngine;
using System.Collections;

public class PlayerSpells : MonoBehaviour {

	public Inventory inventory;

	public GameObject fireball;
	public GameObject frostbolt;
	public GameObject lightningbolt;

	public int fireballDamage = 10;
	public int frostBoltDamage = 5;
	public int LightningDamage = 8;

	// Use this for initialization
	void Start () 
	{
		inventory = this.GetComponent<Inventory>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.E))
		{
			//
			if(inventory.InventoryContains(1) && !inventory.InventoryContains(2) && !inventory.InventoryContains(3))
			{
				int emptySlots = 0;
				for(int i = 0; i < inventory.inventory.Count; ++i)
				{

					//result = inventory[i].itemID == id;
					if(inventory.inventory[i].itemID == 0)
					{
						emptySlots++;

					}
				}
				print ("Found " + emptySlots + " empty slots.");

				if(emptySlots == 2)
				{
					//Do fire spell power 1
					Debug.Log("fire power 1");
					Fireball();
				}
				else if(emptySlots ==1)
				{
					//Do fire spell power 2
					Debug.Log("fire power 2");
					Fireball2();
				}
				else
				{
					//Do fire spell power 3
					Debug.Log("fire power 3");
					Fireball3();
				}
			}
			else if(inventory.InventoryContains(2) && !inventory.InventoryContains(1) && !inventory.InventoryContains(3))
			{
				int emptySlots = 0;
				for(int i = 0; i < inventory.inventory.Count; ++i)
				{
					
					//result = inventory[i].itemID == id;
					if(inventory.inventory[i].itemID == 0)
					{
						emptySlots++;
						
					}
				}
				print ("Found " + emptySlots + " empty slots.");
				
				if(emptySlots == 2)
				{
					//Do water spell power 1
					Debug.Log("water power 1");
					FrostBolt();
				}
				else if(emptySlots ==1)
				{
					//Do water spell power 2
					Debug.Log("water power 2");
					FrostBolt2();
				}
				else
				{
					//Do water spell power 3
					Debug.Log("water power 3");
					FrostBolt3();
				}
			}
			else if(inventory.InventoryContains(3) && !inventory.InventoryContains(1) && !inventory.InventoryContains(2))
			{
				int emptySlots = 0;
				for(int i = 0; i < inventory.inventory.Count; ++i)
				{
					
					//result = inventory[i].itemID == id;
					if(inventory.inventory[i].itemID == 0)
					{
						emptySlots++;
						
					}
				}
				print ("Found " + emptySlots + " empty slots.");
				
				if(emptySlots == 2)
				{
					//Do lightning spell power 1
					Debug.Log("lightning power 1");
					LightningBolt();
				}
				else if(emptySlots ==1)
				{
					//Do water lightning power 2
					Debug.Log("lightning power 2");
					LightningBolt2();
				}
				else
				{
					//Do water lightning power 3
					Debug.Log("lightning power 3");
					LightningBolt3();
				}
			}
			else if(inventory.InventoryContains(1) && inventory.InventoryContains(2) && !inventory.InventoryContains(3))
			{



			}
			else
			{
				int emptySlots = 0;
				for(int i = 0; i < inventory.inventory.Count; ++i)
				{

					//result = inventory[i].itemID == id;
					if(inventory.inventory[i].itemID == 0)
					{
						emptySlots++;

					}
				}
				print ("Found " + emptySlots + " empty slots.");
			}

		}	
	}


	void Fireball()
	{
		int fireballSize = 5;
		int fireballSpeed = 4000;
		fireballDamage = 10;
		GameObject castFireball = Instantiate (fireball, transform.position + transform.forward * (fireballSize*3), transform.rotation) as GameObject; 
		castFireball.transform.localScale *= fireballSize;

		castFireball.rigidbody.AddForce (transform.forward * fireballSpeed);

	}
	void Fireball2()
	{
		int fireballSize = 10;
		int fireballSpeed = 5000;
		fireballDamage = 20;
		GameObject castFireball = Instantiate (fireball, transform.position + transform.forward * (fireballSize*3), transform.rotation) as GameObject; 
		castFireball.transform.localScale *= fireballSize;

		castFireball.rigidbody.AddForce (transform.forward * fireballSpeed);
	}
	void Fireball3()
	{
		int fireballSize = 20;
		int fireballSpeed = 6000;
		fireballDamage = 35;
		GameObject castFireball = Instantiate (fireball, transform.position + transform.forward * (fireballSize*3), transform.rotation) as GameObject; 
		castFireball.transform.localScale *= fireballSize;

		castFireball.rigidbody.AddForce (transform.forward * fireballSpeed);
	}

	void FrostBolt()
	{
		int frostballSize = 2;
		int frostballSpeed = 5000;
		frostBoltDamage = 35;
		GameObject castFrostBolt = Instantiate (frostbolt, transform.position + transform.forward * (frostballSize*3), transform.rotation) as GameObject; 
		GameObject castFrostBolt2 = Instantiate (frostbolt, transform.position + transform.right * frostballSize*3, transform.rotation) as GameObject;
		GameObject castFrostBolt3 = Instantiate (frostbolt, transform.position + -transform.right * frostballSize*3, transform.rotation) as GameObject;
		GameObject castFrostBolt4 = Instantiate (frostbolt, transform.position + -transform.forward * (frostballSize*3), transform.rotation) as GameObject; 

		castFrostBolt.transform.localScale *= frostballSize;
		castFrostBolt.rigidbody.AddForce (transform.forward * frostballSpeed);
		castFrostBolt2.transform.localScale *= frostballSize;
		castFrostBolt2.rigidbody.AddForce (transform.right * frostballSpeed);
		castFrostBolt3.transform.localScale *= frostballSize;
		castFrostBolt3.rigidbody.AddForce (-transform.right * frostballSpeed);
		castFrostBolt4.transform.localScale *= frostballSize;
		castFrostBolt4.rigidbody.AddForce (-transform.forward * frostballSpeed);


	}
	void FrostBolt2()
	{
		int frostballSize = 4;
		int frostballSpeed = 6000;
		frostBoltDamage = 35;
		GameObject castFrostBolt = Instantiate (frostbolt, transform.position + transform.forward * (frostballSize*3), transform.rotation) as GameObject; 
		GameObject castFrostBolt2 = Instantiate (frostbolt, transform.position + transform.right * frostballSize*3, transform.rotation) as GameObject;
		GameObject castFrostBolt3 = Instantiate (frostbolt, transform.position + -transform.right * frostballSize*3, transform.rotation) as GameObject;
		GameObject castFrostBolt4 = Instantiate (frostbolt, transform.position + -transform.forward * (frostballSize*3), transform.rotation) as GameObject; 
		
		castFrostBolt.transform.localScale *= frostballSize;
		castFrostBolt.rigidbody.AddForce (transform.forward * frostballSpeed);
		castFrostBolt2.transform.localScale *= frostballSize;
		castFrostBolt2.rigidbody.AddForce (transform.right * frostballSpeed);
		castFrostBolt3.transform.localScale *= frostballSize;
		castFrostBolt3.rigidbody.AddForce (-transform.right * frostballSpeed);
		castFrostBolt4.transform.localScale *= frostballSize;
		castFrostBolt4.rigidbody.AddForce (-transform.forward * frostballSpeed);

	}
	void FrostBolt3()
	{
		int frostballSize = 8;
		int frostballSpeed = 7000;
		frostBoltDamage = 35;
		GameObject castFrostBolt = Instantiate (frostbolt, transform.position + transform.forward * (frostballSize*3), transform.rotation) as GameObject; 
		GameObject castFrostBolt2 = Instantiate (frostbolt, transform.position + transform.right * frostballSize*3, transform.rotation) as GameObject;
		GameObject castFrostBolt3 = Instantiate (frostbolt, transform.position + -transform.right * frostballSize*3, transform.rotation) as GameObject;
		GameObject castFrostBolt4 = Instantiate (frostbolt, transform.position + -transform.forward * (frostballSize*3), transform.rotation) as GameObject; 
		
		castFrostBolt.transform.localScale *= frostballSize;
		castFrostBolt.rigidbody.AddForce (transform.forward * frostballSpeed);
		castFrostBolt2.transform.localScale *= frostballSize;
		castFrostBolt2.rigidbody.AddForce (transform.right * frostballSpeed);
		castFrostBolt3.transform.localScale *= frostballSize;
		castFrostBolt3.rigidbody.AddForce (-transform.right * frostballSpeed);
		castFrostBolt4.transform.localScale *= frostballSize;
		castFrostBolt4.rigidbody.AddForce (-transform.forward * frostballSpeed);

	}

	void LightningBolt()
	{
		int lightningBoltSize = 1;
		int lightningBoltSpeed = 10000;
		int lightningBoltDamage = 10;

		GameObject castLightningBolt = Instantiate (lightningbolt, transform.position + (transform.forward + transform.right * Random.Range (-5, 5)) * (lightningBoltSize*10), transform.rotation) as GameObject; 

		castLightningBolt.transform.localScale *= lightningBoltSize;
		Vector3 lightningsize = castLightningBolt.transform.localScale;
		lightningsize.z *= 15;
		castLightningBolt.transform.localScale = lightningsize;

		castLightningBolt.rigidbody.AddForce (transform.forward * lightningBoltSpeed);
	}
	void LightningBolt2()
	{
		int lightningBoltSize = 1;
		int lightningBoltSpeed = 12000;
		int lightningBoltDamage = 20;
		GameObject castLightningBolt = Instantiate (lightningbolt, transform.position + (transform.forward + transform.right * Random.Range (-5, 5)) * (lightningBoltSize*10), transform.rotation) as GameObject; 
		
		castLightningBolt.transform.localScale *= lightningBoltSize;
		Vector3 lightningsize = castLightningBolt.transform.localScale;
		lightningsize.z *= 20;
		castLightningBolt.transform.localScale = lightningsize;

		castLightningBolt.rigidbody.AddForce (transform.forward * lightningBoltSpeed);
	}
	void LightningBolt3()
	{
		int lightningBoltSize = 1;
		int lightningBoltSpeed = 14000;
		int lightningBoltDamage = 30;
		GameObject castLightningBolt = Instantiate (lightningbolt, transform.position + (transform.forward + transform.right * Random.Range (-5, 5)) * (lightningBoltSize*10), transform.rotation) as GameObject; 
		
		castLightningBolt.transform.localScale *= lightningBoltSize;
		Vector3 lightningsize = castLightningBolt.transform.localScale;
		lightningsize.z *= 30;
		castLightningBolt.transform.localScale = lightningsize;

		castLightningBolt.rigidbody.AddForce (transform.forward * lightningBoltSpeed);
	}

}
