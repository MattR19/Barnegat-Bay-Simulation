using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;


public class billboards : MonoBehaviour {
	public Camera myCam;
	void Start(){
		myCam = GetComponent<Camera> ();

	}

	void Update() {
		transform.LookAt (Camera.main.transform.position);
	}

}