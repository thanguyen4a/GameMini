using UnityEngine;
using System.Collections;

public class Game : ObservableMonoBehaviour {

	private GameObject HammerSpawner;
	private GameObject ProtectorSpawner;
	private GameObject luffy;
	private GameObject crocodile;

	// Use this for initialization
	void Start () {
		base.OnStart();
		HammerSpawner = GameObject.Find("HammerSpawner");
		ProtectorSpawner = GameObject.Find("ProtectorSpawner");
		spawnLuffy();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			spawnHammer();
		}
	}


	private GameObject spawnHammer()
	{
		GameObject obj = Instantiate(Resources.Load(Config.Hammer.prefabDirection)) as GameObject;
		obj.transform.transform.position = HammerSpawner.transform.position;
		obj.transform.parent = HammerSpawner.transform;
		return obj;
	}	

	private GameObject spawnLuffy()
	{
		if(luffy!=null)return null;

		GameObject obj = Instantiate(Resources.Load(Config.Luffy.prefabDirection)) as GameObject;
		obj.transform.transform.position = ProtectorSpawner.transform.position;
		obj.transform.parent = ProtectorSpawner.transform;

		return luffy = obj;		
	}

	private GameObject spawnCrocodile()
	{
		if(crocodile!= null)return null;

		GameObject obj = Instantiate(Resources.Load(Config.Crocodile.prefabDirection)) as GameObject;
		obj.transform.transform.position = ProtectorSpawner.transform.position;
		obj.transform.parent = ProtectorSpawner.transform;
		return crocodile = obj;		
	}


	private void DestroyLuffy()
	{
		if(luffy!= null)
		GameObject.Destroy(luffy);
	}

	private void DestroyCrocodile()
	{
		if(crocodile!= null)
		GameObject.Destroy(crocodile);
	}


	public override void updateMessage (string message, object data, ObservableObject sender)
	{
		if(message == ButtonMessage.SWITCH_TO_LUFFY)
		{
			spawnLuffy();
			DestroyCrocodile();
		}
		if(message == ButtonMessage.SWITCH_TO_CROCODILE)
		{
			spawnCrocodile();
			DestroyLuffy();
		}

	}




}
