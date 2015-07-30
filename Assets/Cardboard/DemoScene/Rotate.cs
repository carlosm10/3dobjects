using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	bool gazedAt;

	// Use this for initialization
	void Start () {
		//SetGazedAt(false);
		gazedAt = false;


	}
	
	// Update is called once per frame
	void Update () {
		//var rot = Cardboard.SDK.HeadPose.Orientation;

		if (gazedAt) {
			RotateOn ();
		}

	}

	public void SetGazedAt() {
		//GetComponent<Renderer>().material.color = gazedAt ? Color.green : Color.red;
		if(gazedAt=false){
			gazedAt = true;
		}else{
			gazedAt = false;
		}
	}

	public void RotateOn(){
		var rot = Cardboard.SDK.HeadPose.Orientation;
		transform.localRotation = rot;
	}




}
