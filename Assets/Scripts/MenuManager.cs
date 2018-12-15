using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour {

    public static MenuManager Instance { get; set; }
    public GameMode gameMode;

    public GameObject mainMenu;
    public GameObject gameModeMenu;


    private void Awake()
    {
        // umozliwienie dostepu do tego obiektu z roznych scen
        DontDestroyOnLoad(this.gameObject);
        Instance = this;
    }

    // Use this for initialization
    void Start () {
        Screen.orientation = ScreenOrientation.Landscape;
        Screen.SetResolution(1920, 1080, false);
        mainMenu.SetActive(true);
        gameModeMenu.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    // ustawienie trybu rozgrywki
    public void SetGameMode(GameMode mode)
    {
        this.gameMode = mode;
    }

    // przelaczanie miedzy glownym menu a menu wyboru rozgrywki
    public void SwitchMenu()
    {
        mainMenu.SetActive(!mainMenu.activeSelf);
        gameModeMenu.SetActive(!gameModeMenu.activeSelf);
    }
}
