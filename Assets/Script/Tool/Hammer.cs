using UnityEngine;
using System.Collections;

public class Hammer : MonoBehaviour {


	// Use this for initialization
	private float v0;
	private float min_v0;
	private float max_v0;
	private float anpha;
	private float minAnpha;
	private float maxAnpha;
	private float x0;
	private float y0;
	private float w;

	void Start () {
		v0 = Config.Hammer.v0;
		anpha = Config.Hammer.anpha;
		minAnpha = Config.Hammer.minAnpha;
		maxAnpha = Config.Hammer.maxAnpha;
		min_v0 = Config.Hammer.min_v0;
		max_v0 = Config.Hammer.max_v0;
		Vector3 pos = gameObject.transform.position;
		x0 = pos.x;
		y0 = pos.y;
		w = Config.Hammer.w;
		anpha = Random.Range(minAnpha,maxAnpha);
		v0 = Random.Range(min_v0,max_v0);
	}

	// Update is called once per frame
	void Update () {
		OnMove(Time.deltaTime);

		checkOnDestroy();
	}

	private void OnMove(float deltaTime)
	{
		Vector3 pos = gameObject.transform.position;
		//float dx = -v0*Mathf.Cos(anpha)*deltaTime;
		pos.x -= v0*Mathf.Cos(anpha)*deltaTime;
		//pos.y+= dx*Mathf.Tan(anpha);
		pos.y = y0+(x0-pos.x)*Mathf.Tan(anpha) - Config.Gravity.gravity*Mathf.Pow(x0-pos.x,2)/(2*v0*Mathf.Pow(Mathf.Cos(anpha),2));
		gameObject.transform.position = pos;
	}

	private void checkOnDestroy()
	{
		Vector3 pos = gameObject.transform.position;
		if(pos.y<=-5)GameObject.Destroy(gameObject);
	}


	}
