using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeScript : MonoBehaviour {
	private const int TIME_VAR = 15;
	public Renderer render0;
	public Renderer render1;
	public Renderer render2;
	public Renderer render3;
	public Renderer render4;
	public Renderer render5;
	public string year;
	private float seconds;
	private float startTime;

	// Use this for initialization
	void Start () {

		startTime = Time.time;
		render0 = GetComponent<Renderer>();
		render0.enabled = true;
		render1 = GameObject.Find("AlgaeMap2").GetComponent<MeshRenderer>();
		render1.enabled = false;
		render2 = GameObject.Find("AlgaeMap3").GetComponent<MeshRenderer>();
		render2.enabled = false;
		render3 = GameObject.Find("AlgaeMap4").GetComponent<MeshRenderer>();
		render3.enabled = false;
		render4 = GameObject.Find("AlgaeMap5").GetComponent<MeshRenderer>();
		render4.enabled = false;
		render5 = GameObject.Find("AlgaeMap6").GetComponent<MeshRenderer>();
		render5.enabled = false;

	}

	// Update is called once per frame
	void Update () {
		year =  GameObject.Find("UItext").GetComponent<TimeScript>().year;
		seconds = Time.time - startTime;

		if (year.Equals("1995") || year.Equals("1997")){
			render0.enabled = true;
			render1.enabled = false;
			render5.enabled = false;
		}
		else if (year.Equals("1999") || year.Equals("2000")|| year.Equals("2001")){
			render0.enabled = false;
			render1.enabled = true;
			render5.enabled = false;
		}
		else if (year.Equals("2002") )
		{
			render1.enabled = false;
			render2.enabled = true;
			render5.enabled = false;
		}
		else if (year.Equals("2004") )
		{
			render2.enabled = false;
			render3.enabled = true;
			render5.enabled = false;
		}
		else if (year.Equals("2011"))
		{
			render3.enabled = false;
			render4.enabled = true;
			render5.enabled = false;
		}
		else		{
			render0.enabled = false;
			render1.enabled = false;
			render2.enabled = false;
			render3.enabled = false;
			render4.enabled = false;
			render5.enabled = true;
		}
		

	}//end Update()
}
