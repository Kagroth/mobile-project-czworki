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

    public void SetGameMode(GameMode mode)
    {
        this.gameMode = mode;
    }

    public void SwitchMenu()
    {
        mainMenu.SetActive(!mainMenu.activeSelf);
        gameModeMenu.SetActive(!gameModeMenu.activeSelf);
    }
}
