using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HouseOpacity : MonoBehaviour {
	private float seconds;
	private float startTime;
	private MeshRenderer[] renderers;
	private Collider[] houseColliders ;
	public GameObject UItext;
    public GameObject myCamera; 
	GameObject[] thirtyBox;
	GameObject[] sixtyBox;
	GameObject[] nine0Box;
	GameObject[] twelve0Box;
	GameObject[] fifteen0Box;
	GameObject[] eighteen0Box;
	GameObject[] twenty10Box;
	GameObject[] twenty40Box;
	
	GameObject[] thirtySecondHouses;
	GameObject[] sixtySecondHouses;
	GameObject[] nine0SecHouses;
	GameObject[] twelve0SecHouses;
	GameObject[] fifteen0SecHouses;
	GameObject[] eighteen0SecHouses;
	GameObject[] twenty10SecHouses;
	GameObject[] twenty40SecHouses;
	GameObject[] clusterHouses;
	bool clusterButtonIsClicked=false;
	bool foundationButtonIsClicked= false;
	public string year;
	public Button clusterDButton;

	// Use this for initialization
	void Start () {
       
		startTime = Time.time;	
		//Button btn1 = clusterDButton.GetComponent<Button> ();
		//btn1.onClick.AddListener (TaskOnClick);
		thirtySecondHouses = GameObject.FindGameObjectsWithTag ("30sechouse");
		thirtyBox = GameObject.FindGameObjectsWithTag("30box");

		sixtySecondHouses = GameObject.FindGameObjectsWithTag ("60sechouse");
		sixtyBox = GameObject.FindGameObjectsWithTag("60box");
		ShutOffHouses (sixtySecondHouses);
		TurnOffObjects (sixtyBox);

		nine0SecHouses = GameObject.FindGameObjectsWithTag ("90sechouse");
		nine0Box = GameObject.FindGameObjectsWithTag("90box");
		ShutOffHouses (nine0SecHouses);
		TurnOffObjects (nine0Box);

		twelve0SecHouses = GameObject.FindGameObjectsWithTag ("120sechouse");
		twelve0Box = GameObject.FindGameObjectsWithTag("120box");
		ShutOffHouses (twelve0SecHouses);
		TurnOffObjects (twelve0Box);

		fifteen0SecHouses = GameObject.FindGameObjectsWithTag ("150sechouse");
		fifteen0Box = GameObject.FindGameObjectsWithTag("150box");
		ShutOffHouses (fifteen0SecHouses);
		TurnOffObjects (fifteen0Box);

		eighteen0SecHouses = GameObject.FindGameObjectsWithTag ("180sechouse");
		eighteen0Box = GameObject.FindGameObjectsWithTag("180box");
		ShutOffHouses (eighteen0SecHouses);
		TurnOffObjects (eighteen0Box);

		twenty10SecHouses = GameObject.FindGameObjectsWithTag ("210sechouse");
		twenty10Box = GameObject.FindGameObjectsWithTag("210box");
		ShutOffHouses (twenty10SecHouses);
		TurnOffObjects (twenty10Box);

		twenty40SecHouses = GameObject.FindGameObjectsWithTag ("240sechouse");
		twenty40Box = GameObject.FindGameObjectsWithTag("240box");
		ShutOffHouses (twenty40SecHouses); 
		TurnOffObjects (twenty40Box);

		clusterHouses = GameObject.FindGameObjectsWithTag("clusterHouses");
		ShutOffHouses (clusterHouses);

	}
	
	// Update is called once per frame
	void Update (){
		year =  UItext.GetComponent<TimeScript>().year;
		seconds = Time.time - startTime;

		//makes children of house turn on and collidable
		if (year.Equals("1996")) {
			TurnOnHouses (sixtySecondHouses);
			TurnOnObjects (sixtyBox);
		}//end if statement
			else if (year.Equals("1997"))
			{
			TurnOnHouses (nine0SecHouses);
			TurnOnObjects (nine0Box);
			}//end of else if
			else if (year.Equals("1998"))
			{
			TurnOnHouses (twelve0SecHouses);
			TurnOnObjects (twelve0Box);
			}//end of else if
			else if (year.Equals("1999"))
			{
			TurnOnHouses (fifteen0SecHouses);
			TurnOnObjects (fifteen0Box);
			}//end of else if
			else if (year.Equals("2000"))
			{
			TurnOnHouses (eighteen0SecHouses);
			TurnOnObjects (eighteen0Box);
			}//end of else if
			else if (year.Equals("2001"))
			{
			TurnOnHouses (twenty10SecHouses);
			TurnOnObjects (twenty10Box);
			}//end of else if
			else if (year.Equals("2002"))
			{
			TurnOnHouses (twenty40SecHouses);
			TurnOnObjects (twenty40Box);
			}//end of else if
			

	}//end Update()


	private void ShutOffHouses (GameObject[] arrayHouses){
		for(int i=0; i<arrayHouses.Length;i++) {
			renderers = arrayHouses[i].GetComponentsInChildren<MeshRenderer>();
			foreach (MeshRenderer r in renderers) {
				r.enabled=false;
			}
			houseColliders = arrayHouses[i].GetComponentsInChildren<Collider> ();
			foreach (Collider c in houseColliders) {
				c.enabled=false;
			}
		}
	} // end of shut off

	private void TurnOnHouses (GameObject [] arrayHouses){
		for(int i=0; i<arrayHouses.Length;i++) {
			renderers = arrayHouses[i].GetComponentsInChildren<MeshRenderer>();
			foreach (MeshRenderer r in renderers) {
				r.enabled= true;
			}
			houseColliders = arrayHouses[i].GetComponentsInChildren<Collider> ();
			foreach (Collider c in houseColliders) {
				c.enabled= true;
			}
		}
	} // end of turn on

	private void TurnOnObjects (GameObject [] arrayOfObjects){
		for(int i=0; i<arrayOfObjects.Length;i++) {
			renderers = arrayOfObjects[i].GetComponents<MeshRenderer>();
			foreach (MeshRenderer r in renderers) {
				r.enabled= true;
			}
			houseColliders = arrayOfObjects[i].GetComponents<Collider> ();
			foreach (Collider c in houseColliders) {
				c.enabled= true;
			}
		}
	} //end TurnOnObjects()

	private void TurnOffObjects (GameObject [] arrayOfObjects){
		for(int i=0; i<arrayOfObjects.Length;i++) {
			renderers = arrayOfObjects[i].GetComponents<MeshRenderer>();
			foreach (MeshRenderer r in renderers) {
				r.enabled= false;
			}
			houseColliders = arrayOfObjects[i].GetComponents<Collider> ();
			foreach (Collider c in houseColliders) {
				c.enabled= false;
			}
		}
	} //end TurnOffObjects()

	public void changeOpacity () {
        myCamera.transform.position = new Vector3(124.9f, 544.0f, 449.0f);
        //Delay(2000);
		clusterButtonIsClicked = !clusterButtonIsClicked;

		if (clusterButtonIsClicked == true) {
			ShutOffHouses (nine0SecHouses);
			TurnOffObjects (nine0Box);
			ShutOffHouses (twelve0SecHouses);
			TurnOffObjects (twelve0Box);
			ShutOffHouses (eighteen0SecHouses);
			TurnOffObjects (eighteen0Box);
			ShutOffHouses (twenty10SecHouses);
			TurnOffObjects (twenty10Box);
			ShutOffHouses (twenty40SecHouses);
			TurnOffObjects (twenty40Box);
			TurnOnHouses (clusterHouses);
		} // end of if statement
		else if (clusterButtonIsClicked == false) {
			TurnOnObjects (thirtyBox);
			TurnOnObjects (sixtyBox);
			TurnOnHouses (nine0SecHouses);
			TurnOnObjects (nine0Box);
			TurnOnHouses (twelve0SecHouses);
			TurnOnObjects (twelve0Box);
			TurnOnHouses (fifteen0SecHouses);
			TurnOnObjects (fifteen0Box);
			TurnOnHouses (eighteen0SecHouses);
			TurnOnObjects (eighteen0Box);
			TurnOnHouses (twenty10SecHouses);
			TurnOnObjects (twenty10Box);
			TurnOnHouses (twenty40SecHouses);
			TurnOnObjects (twenty40Box);
			ShutOffHouses (clusterHouses);
		}
		return;

	}//end changeOpacity()

	public void changeFoundationOpacity () {
        myCamera.transform.position = new Vector3(124.9f, 544.0f, 449.0f);
        foundationButtonIsClicked = !foundationButtonIsClicked;

		if (foundationButtonIsClicked == true) {
			TurnOnHouses (thirtySecondHouses);
			TurnOnHouses (sixtySecondHouses);
			TurnOnHouses (nine0SecHouses);
			TurnOnHouses (twelve0SecHouses);
			TurnOnHouses (fifteen0SecHouses);
			TurnOnHouses (eighteen0SecHouses);
			TurnOnHouses (twenty10SecHouses );
			TurnOnHouses (twenty40SecHouses);
			TurnOffObjects (thirtyBox);
			TurnOffObjects (sixtyBox);
			TurnOffObjects (nine0Box);
			TurnOffObjects (twelve0Box);
			TurnOffObjects (fifteen0Box);
			TurnOffObjects (eighteen0Box);
			TurnOffObjects (twenty10Box);
			TurnOffObjects (twenty40Box);
		} // end of if statement

		else if (foundationButtonIsClicked == false) {
			TurnOnObjects (thirtyBox);
			TurnOnObjects (sixtyBox);
			TurnOnObjects (nine0Box);
			TurnOnObjects (twelve0Box);
			TurnOnObjects (fifteen0Box);
			TurnOnObjects (eighteen0Box);
			TurnOnObjects (twenty10Box);
			TurnOnObjects (twenty40Box);
		}
		return;

	}//end changeOpacity()
		
	
	
	
}//end of Class
