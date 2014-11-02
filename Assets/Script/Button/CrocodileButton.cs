using UnityEngine;
using System.Collections;

public class CrocodileButton :ObservableMonoBehaviour, UILib.SimpleButtonDelegate {

	// Use this for initialization
	void Start () {
		base.OnStart();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void onClicked(UnityEngine.GameObject go)
	{
		Debug.Log ("Onclick switch crocodile");
		sendMessage(ButtonMessage.SWITCH_TO_CROCODILE,null);
	}
	public void onClickEnd(UnityEngine.GameObject go)
	{

	}
}
