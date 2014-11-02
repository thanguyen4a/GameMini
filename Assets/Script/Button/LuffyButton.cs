using UnityEngine;
using System.Collections;

public class LuffyButton :ObservableMonoBehaviour, UILib.SimpleButtonDelegate {

	// Use this for initialization
	void Start () {
		base.OnStart();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void onClicked(UnityEngine.GameObject go)
	{
		Debug.Log ("Onclick switch luffy");
		sendMessage(ButtonMessage.SWITCH_TO_LUFFY,null);
	}
	public void onClickEnd(UnityEngine.GameObject go)
	{
		
	}
}
