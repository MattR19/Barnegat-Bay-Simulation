using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour {
    private int timeV = 2;
	public string year;
	private int numYear;
	private float seconds;
	private float startTime;
    private GameObject settingsBtn;
    public Text timerText;
	// Use this for initialization
	public void Start () {
		startTime = Time.time;
		timerText = this.GetComponent<Text> ();
        
        //settingsBtn.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
       
		seconds = Time.time - startTime;

		if (seconds<=timeV) {
			year = "1995";
		} 
		else if (seconds > timeV && seconds <= (2* timeV) ) {
			year = "1996";
		}
		else if (seconds > (2* timeV) && seconds <= (3* timeV) ) {
			year = "1997";
		}
		else if (seconds > (3* timeV) && seconds <= (4* timeV) ) {
			year = "1998";
		}
		else if (seconds > (4* timeV) && seconds <= (5* timeV) ) {
			year = "1999";
		}
		else if (seconds > (5* timeV) && seconds <= (6* timeV) ) {
			year = "2000";
		}
		else if (seconds > (6* timeV) && seconds <= (7* timeV) ) {
			year = "2001";
		}
		else if (seconds > (7* timeV) && seconds <= (8* timeV) ) {
			year = "2002";
		}
		else if (seconds > (8* timeV) && seconds <= (9* timeV) ) {
			year = "2003";
		}
		else if (seconds > (9* timeV) && seconds <= (10* timeV) ) {
			year = "2004";
		}
		else if (seconds > (10* timeV) && seconds <= (11* timeV) ) {
			year = "2005";
		}
		else if (seconds > (11* timeV) && seconds <= (12* timeV) ) {
			year = "2006";
		}
		else if (seconds > (12* timeV) && seconds <= (13* timeV) ) {
			year = "2007";
		}
		else if (seconds > (13* timeV) && seconds <= (14* timeV) ) {
			year = "2008";
		}
		else if (seconds > (14* timeV) && seconds <= (15* timeV) ) {
			year = "2009";
		}
		else if (seconds > (15* timeV) && seconds <= (16* timeV) ) {
			year = "2010";
		}
		else if (seconds > (16* timeV) && seconds <= (17* timeV) ) {
			year = "2011";
		}
		else if (seconds > (17* timeV) && seconds <= (18* timeV) ) {
			year = "2012";
		}
		else if (seconds > (18* timeV) && seconds <= (19* timeV) ) {
			year = "2013";
		}
		else if (seconds > (19* timeV) && seconds <= (20* timeV) ) {
			year = "2014";
		}
		else if (seconds > (20* timeV) && seconds <= (21* timeV) ) {
			year = "2015";
		}
		else if (seconds > (21* timeV) && seconds <= (22* timeV) ) {
			year = "2016";
           // settingsBtn.SetActive(true);
        }
        
        timerText.text = year;
	}// end of update method
		
}