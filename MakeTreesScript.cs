using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeTreesScript : MonoBehaviour {
	public Vector3 center;
	public Vector3 size;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnDrawGizmosSelected(){
		Gizmos.color = new Color (1, 0, 0, .5f);
		Gizmos.DrawCube (transform.localPosition+ center, size);
	
	}
}
