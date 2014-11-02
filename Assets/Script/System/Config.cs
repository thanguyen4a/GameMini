using UnityEngine;
using System.Collections;


public static class Config  {

	public static class Hammer
	{
		public  static readonly float v0 = 8f; // van toc ban dau
		public  static readonly float w =  1000f;   // van toc goc   dv : rad/s 
		public  static readonly float anpha = Mathf.PI/6; // pha ban dau (goc nem ngang ban dau)  dv : rad

		public  static readonly float minAnpha = Mathf.PI/12;
		public  static readonly float maxAnpha = Mathf.PI/4f;

		public  static readonly float min_v0 = 8f;
		public  static readonly float max_v0 = 16f;


		public 	static readonly string prefabDirection = "Prefab/Tool/hammer";
	}


	public static class Luffy
	{
		public 	static readonly string prefabDirection = "Prefab/Avatar/Luffy";
	}


	public static class Crocodile
	{
		public 	static readonly string prefabDirection = "Prefab/Avatar/Crocodile";
	}


	public static class Gravity
	{
		public  static readonly float gravity = 1f; // gia toc trong truong
	}

}
