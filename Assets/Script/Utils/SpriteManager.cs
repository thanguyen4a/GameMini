// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;
using System.Collections;
using UnityEngine;

public class SpriteManager
{
	private static Hashtable  _instances = new Hashtable();
	private Hashtable texture_map;


	public static SpriteManager getSingleton(string code){
		if(!_instances.ContainsKey(code)){
			SpriteManager manager = new SpriteManager();
			manager.load(code);
			_instances.Add(code, manager);
		}
		return (_instances[code] as SpriteManager);
	}

	private void load(string code){
		Sprite[] textures = Resources.LoadAll<Sprite>(code);
		texture_map = new Hashtable();

		for(int ii=0; ii< textures.Length; ii++) {
			texture_map.Add(textures[ii].name, textures[ii]);
			Debug.Log (ii + ":" + textures[ii].name);
		}
	}

	public SpriteManager ()
	{

	}

	public Sprite getSprite(string sprite_name){
		if(texture_map.ContainsKey(sprite_name)){
			Sprite sprite = texture_map[sprite_name] as Sprite;
			Debug.Log("GetSprite:"+sprite_name + " -> "+ sprite);
			return sprite;
		}
		return null;
	}
}
