using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonClear : MonoBehaviour {
    public GameObject UItext;
    private float seconds;
    private float startTime;
    public string year;
    public GameObject clusterDButton;
    public GameObject perviousB;
    public GameObject woodedB;
    // Use this for initialization
    void Start () {
        startTime = Time.time;
        clusterDButton.SetActive(false);
        perviousB.SetActive(false);
        woodedB.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        year = UItext.GetComponent<TimeScript>().year;
        seconds = Time.time - startTime;
        if (year.Equals("2016"))
        {
            clusterDButton.SetActive(true);
            perviousB.SetActive(true);
            woodedB.SetActive(true);
        }
    }
}
