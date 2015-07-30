using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	bool gazedAt;

	// Use this for initialization
	void Start () {
		//gazedAt= false;
	}
	
	// Update is called once per frame
	void Update () {
		/*if (gazedAt) {
			RotateOn();
		}*/

		var rot = Cardboard.SDK.HeadPose.Orientation;
		transform.localRotation = rot;
	}
	/*
	public void Selected(){
		gazedAt = true;
		//Debug.Log( GameObject.Find("Pic").transform.position);
	}

	public void RotateOn(){

	}*/
}
