using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {
	public GameObject settingsMenu;
	public GameObject inGameMenu;
    // Use this for initialization
    public enum MenuStates {Game, Settings};
	public MenuStates currentState;
	void Start ()
	{
		currentState = MenuStates.Game;
		
	}

	void Update()
	{
		switch (currentState) 
		{
		case MenuStates.Game :
            inGameMenu.SetActive(true);
			settingsMenu.SetActive(false);
            break;

		case MenuStates.Settings:
			settingsMenu.SetActive (true);
			inGameMenu.SetActive (false);
            break;
         default:
			break;
		}
	}

	public void onSettings() //for settings button
	{
		currentState = MenuStates.Settings;
		
	}

	public void onBack() //for back button
	{
		currentState = MenuStates.Game;
	}

    public void onStart()
    {
        currentState = MenuStates.Game;
    }

}
