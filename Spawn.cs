using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
	public GameObject type;
	private bool treesAreOn = false;
    public GameObject myCam;
	// Use this for initialization

	public void create(int num){
        myCam.transform.position = new Vector3(168.3552f, 544.0f, 170.5267f);
        for (int x=0;x<num;x++){
			Instantiate(type, getRandLoc(), new Quaternion(0,0,0,0));
		}
	}//end create()
	Vector3 getRandLoc(){
		float rX=Random.Range(113.7f,196.4f);
		float rY=Random.Range(539.2f,539.3f);        //These values will likely have to be adjusted	
		float rZ=Random.Range(144.1f,201.9f);
		return new Vector3(rX,rY,rZ);

	}//end getrandLoc()

	public void changeTrees(){
		treesAreOn = !treesAreOn;
		GameObject[] arrayOfBushes = GameObject.FindGameObjectsWithTag ("bush");

        if (treesAreOn) { create (100);	} 
		else 
		{	for (int i = 0; i < arrayOfBushes.Length; i++) 
				Destroy (arrayOfBushes [i]);
		}//end else


	
	}




}
